using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
         425       
                
                IPAddress serverIpAddress = IPAddress.Parse("10.0.0.40"); // IP address of the server
                int port = 20; // port number that the server is listening on

                using Socket client = new(
                    serverIpAddress.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp);


                await client.ConnectAsync(serverIpAddress, port);
                Console.WriteLine("Connected to server: {0}", client.RemoteEndPoint);

                byte[] buffer = new byte[1024];
                while (true)
                {
                   
                    int numBytes = await client.ReceiveAsync(buffer, SocketFlags.None);
                    string chatLog = Encoding.UTF8.GetString(buffer, 0, numBytes);
                
                    Console.WriteLine(chatLog);
                
                    // read messages from the console and send them to the server
                    while (true)
                    {
                        Console.Write("Enter message: ");
                        string message = Console.ReadLine();
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        await client.SendAsync(data, SocketFlags.None);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}