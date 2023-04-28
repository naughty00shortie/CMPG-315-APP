using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IPAddress ipAddress = IPAddress.Any; // listen on any available IP address
            int port = 20; // port number to listen on

            IPEndPoint ipEndPoint = new(ipAddress, port);

            using Socket listener = new(
                ipEndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);

            listener.Bind(ipEndPoint);
            listener.Listen(1);

            Console.WriteLine("Server started. Listening for connections...");
            List<Socket> connectedClients = new List<Socket>();
            while (true)
            { 
                try
                {
                    Socket client = await listener.AcceptAsync();
                    connectedClients.Add(client);
                    Console.WriteLine("Client connected: {0}", client.RemoteEndPoint);

                    IPEndPoint remoteIpEndPoint = (IPEndPoint)client.RemoteEndPoint;
                    IPAddress clientIpAddress = remoteIpEndPoint.Address;
                    Console.WriteLine("Client IP address: {0}", clientIpAddress);

                    
                    string chatLog = File.ReadAllText("chatlog.txt");
                    byte[] chatLogBytes = Encoding.UTF8.GetBytes(chatLog);
                    await client.SendAsync(chatLogBytes, SocketFlags.None);

                    Task.Run(() => ReceiveMessages(client, connectedClients));
                        
                    
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static async Task ReceiveMessages(Socket client, List<Socket> connectedClients)
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int numBytes = await client.ReceiveAsync(buffer, SocketFlags.None);
                string message = Encoding.UTF8.GetString(buffer, 0, numBytes);
                Console.WriteLine("Received message: " + message);
                string chatLog = File.ReadAllText("chatlog.txt");
                chatLog += message + "\n";
                File.WriteAllText("chatlog.txt", chatLog);
                byte[] chatLogBytes = Encoding.UTF8.GetBytes(chatLog);
                foreach (Socket connectedClient in connectedClients)
                { 
                    if(connectedClient != client)
                        await connectedClient.SendAsync(chatLogBytes, SocketFlags.None);
                }
            }
        }
    }
}
