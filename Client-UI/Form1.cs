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
        private string connectedName;
        public Form1(string name)
        {
            InitializeComponent();
            connectedName = name;
            Connect();
        }


        private async void Connect()
        {
            IPAddress serverIpAddress = IPAddress.Parse("64.226.64.204");//127.0.0.1    64.226.64.204
            int port = 20;

            try
            {
                server = new Socket(serverIpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                await server.ConnectAsync(serverIpAddress, port);
                sendMessage("#NAME#" + connectedName);


                Task.Run(() => ReceiveMessages());
                label4.Text = "Connected as: " + connectedName;
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
                    message = message.Replace("#LIST#", "").Replace("\n", "");
                    message.Split('|', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x =>
                    {
                        listBox1.Invoke(new Action(() =>
                        {
                            if (x!= connectedName)
                            {
                                listBox1.Items.Add(x);
                            }
                        }));
                    });
                }
                else if (message.Contains("#CHAT#"))
                {
                    message = message.Replace("#CHAT#", "");
                    richTextBox1.Invoke(new Action(() =>
                    {
                        richTextBox1.Clear();
                        richTextBox1.AppendText(message + "\n");
                    }));
                }
                else if(message.Contains("#GROUP#"))
                {
                    if (message.Contains("|"))
                    {
                        message = message.Substring(0, message.Length - 1);
                        listBox1.Invoke(new Action(() =>
                        {
                            listBox3.Items.Clear();
                            listBox3.Items.Add("Global");
                        }));
                        message = message.Replace("#GROUP#", "").Replace("\n", "");
                        message.Split('|', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x =>
                        {
                            listBox1.Invoke(new Action(() =>
                            {
                                if (x != connectedName)
                                {
                                    listBox3.Items.Add(x);
                                }
                            }));
                        });
                    }
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

        public async void sendMessage(string message)
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGroup frmGroup = new FrmGroup(listBox1,this,connectedName);
            frmGroup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!= null)
            {
                richTextBox1.Clear();
                string message = listBox1.SelectedItem.ToString().Replace("\n", "");
                sendMessage("#CHAT#" + message);
                label5.Text = "Chatting in: " + message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem!= null)
            {
                richTextBox1.Clear();
                string message = listBox3.SelectedItem.ToString().Replace("\n", "");
                sendMessage("#GROUP#" + message);
                label5.Text = "Chatting in: " + message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}