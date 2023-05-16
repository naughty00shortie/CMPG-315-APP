using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_UI
{
    public partial class FrmGroup : Form
    {
        private ListBox mainListBox;
        private Form1 mainForm;
        private string name;
        public FrmGroup(ListBox listbox, Form1 form, string name)
        {
            InitializeComponent();
            mainListBox = listbox;
            mainForm = form;
            this.name = name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "#CREATE#" + name + "|";
            foreach (var item in listBox2.Items)
            {
                message += item.ToString() + "|";
            }

            mainForm.sendMessage(message.Substring(0, message.Length - 1));
            this.Close();
        }

        private void FrmGroup_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in mainListBox.Items)
            {
                if (item.ToString() != "Global")
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnRemoveFromGroup_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            string message = "#CREATE#" + name + "|";
            foreach (var item in listBox2.Items)
            {
                message += item.ToString() + "|";
            }

            mainForm.sendMessage(message.Substring(0, message.Length - 1));
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
