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
                    client._chat = "chats/Global.txt";
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
                Client client = connectedClients.Find(client => client._socket == clientSocket);
                if (message == "#DISCONNECT#")//Disconnects the client
                {
                    connectedClients.Find(client => client._socket == clientSocket)._socket.Close();
                    Console.WriteLine( connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket)));
                    SendUpdatedClientList();
                }
                else if (message.Contains("#NAME#"))//Adds the name of the client to the list
                {

                    message = message.Replace("#NAME#", "");
                    Console.WriteLine( connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket)));
                    client._name = message;
                    connectedClients.Add(client);
                     SendUpdatedClientList();
                }
                else if (message.Contains("#CHAT#"))
                {
                    
                    message = message.Replace("#CHAT#", "");

                    if (message.Contains("Global"))
                    {
                       
                        Console.WriteLine( connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket)));
                        client._chat = "chats/Global.txt";
                        connectedClients.Add(client);
                        string chatLog = File.ReadAllText("chats/Global.txt");
                        byte[] chatLogBytes = Encoding.UTF8.GetBytes("#CHAT#"+chatLog);
                        await clientSocket.SendAsync(chatLogBytes, SocketFlags.None);
                    }
                    else 
                    {
                        string filename = findFile(client._name, message);
                        client._chat = filename;
                        Console.WriteLine( connectedClients.Remove(connectedClients.Find(client => client._socket == clientSocket)));
                        connectedClients.Add(client);
                        string chatLog = File.ReadAllText(filename);
                        byte[] chatLogBytes = Encoding.UTF8.GetBytes("#CHAT#"+chatLog);
                        await clientSocket.SendAsync(chatLogBytes, SocketFlags.None);
                    }
                }
                else
                {
                    string chatLog = File.ReadAllText(client._chat);
                    chatLog += client._name+": " + message + "\n";
                    File.WriteAllText(client._chat, chatLog);
                    byte[] chatLogBytes = Encoding.UTF8.GetBytes( client._name+": " + message+"\n");
                    foreach (Client connectedClient in connectedClients)
                    { 
                        Console.WriteLine(connectedClient._chat);
                        Console.WriteLine(client._chat);
                         if(connectedClient._chat == client._chat)
                             await connectedClient._socket.SendAsync(chatLogBytes, SocketFlags.None);
                    }
                }
            }
        }

        private static string findFile(string name, string message)
        {
            DirectoryInfo d = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chats"));
            foreach (var file in d.GetFiles())
            {
                if (file.Name != "Global.txt") 
                {
                    string[] split = file.Name.Replace(".txt","").Split('-');
                    if ((split[0] == name && split[1] == message) || (split[0] == message && split[1] == name))
                    {
                        Console.WriteLine("Found file");
                        return "chats/" + file.Name;
                    }
                }
            }
            
            //create file
            string path = "chats/" + name + "-" + message + ".txt";
            File.Create(path).Close();
            Console.WriteLine("Created new file");
            return path;
        }
    }
}
