using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Client_UI
{
    public partial class Form1 : Form
    {
        private Socket server;
        public Form1(string name)
        {
            InitializeComponent();
            Connect(name);
        }


        private async void Connect(string name)
        {
            IPAddress serverIpAddress = IPAddress.Parse("127.0.0.1");
            int port = 20;

            try
            {
                
                server = new Socket(serverIpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                await server.ConnectAsync(serverIpAddress, port);
                sendMessage("#NAME#" + name);


                Task.Run(() => ReceiveMessages());
                label4.Text = "Connected as: " + name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to server: " + ex.Message);
            }
        }


        private async Task ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int numBytes = await server.ReceiveAsync(buffer, SocketFlags.None);
                string message = Encoding.UTF8.GetString(buffer, 0, numBytes);

                if (message.Contains("#LIST#"))
                {
                    listBox1.Invoke(new Action(() =>
                    {
                        listBox1.Items.Clear();
                    }));
                    message = message.Replace("#LIST#", "");
                    message.Split('|', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x =>
                    {
                        listBox1.Invoke(new Action(() =>
                        {
                            listBox1.Items.Add(x);
                        }));
                    });
                }
                else
                {
                    richTextBox1.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(message);
                    }));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendMessage(textBox2.Text);
        }

        private async void sendMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                await server.SendAsync(data, SocketFlags.None);

                textBox2.Text = "";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sendMessage("#DISCONNECT#");
            Thread.Sleep(500);
            Application.Exit();
        }
    }
}