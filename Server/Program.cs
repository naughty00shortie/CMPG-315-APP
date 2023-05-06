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
        private struct Client
        {
            public Socket _socket;
            public string _name;
            public string _chat;
        }
        private static List<Client> connectedClients = new List<Client>();
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
             
            while (true)
            { 
                try
                {
                    Client client = new Client();
                    client._chat = "Global";
                    client._socket = await listener.AcceptAsync();
                    connectedClients.Add(client);
                    Console.WriteLine("Client connected: {0}", client._socket.RemoteEndPoint);

                    IPEndPoint remoteIpEndPoint = (IPEndPoint)client._socket.RemoteEndPoint;
                    IPAddress clientIpAddress = remoteIpEndPoint.Address;
                    Console.WriteLine("Client IP address: {0}", clientIpAddress);
                    
                    string chatLog = File.ReadAllText("chats/Global.txt");
                    byte[] chatLogBytes = Encoding.UTF8.GetBytes(chatLog);
                    await client._socket.SendAsync(chatLogBytes, SocketFlags.None);

                    Task.Run(() => ReceiveMessages(client._socket));
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static async Task SendUpdatedClientList()
        {
            Thread.Sleep(1000);
            string clientList = "#LIST#";
            foreach (var client in connectedClients)
            {
                clientList += client._name + "|\n";
            }
            foreach (var client in connectedClients)
            {
                byte[] clientListBytes = Encoding.UTF8.GetBytes(clientList);
                await client._socket.SendAsync(clientListBytes, SocketFlags.None);
            }
        }
        static async Task ReceiveMessages(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int numBytes = await clientSocket.ReceiveAsync(buffer, SocketFlags.None);
                string message = Encoding.UTF8.GetString(buffer, 0, numBytes);
                Console.WriteLine("Received message: " + message);
                if (message == "#DISCONNECT#")//Disconnects the client
                {
                    connectedClients.Find(client => client._socket == clientSocket)._socket.Close();
                    connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket));
                    SendUpdatedClientList();
                }
                else if (message.Contains("#NAME#"))//Adds the name of the client to the list
                {
                    message = message.Remove(0, 6);
                    Client client = connectedClients.Find(client => client._socket == clientSocket);
                    connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket));
                    client._name = message;
                    connectedClients.Add(client);
                     SendUpdatedClientList();
                }
                else
                {
                    string chatLog = File.ReadAllText("chats/Global.txt");
                    chatLog += message + "\n";
                    File.WriteAllText("chats/Global.txt", chatLog);
                    byte[] chatLogBytes = Encoding.UTF8.GetBytes( connectedClients.Find(client => client._socket == clientSocket)._name+": " + message+"\n");

                    foreach (Client connectedClient in connectedClients)
                    { 
                        // if(connectedClient._socket != clientSocket)
                             await connectedClient._socket.SendAsync(chatLogBytes, SocketFlags.None);
                    }
                }
            }
        }
    }
}
