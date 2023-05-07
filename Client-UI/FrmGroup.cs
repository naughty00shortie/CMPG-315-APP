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
        public FrmGroup(ListBox listbox, Form1 form)
        {
            InitializeComponent();
            mainListBox = listbox;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "#GROUP#";
            foreach (var item in listBox2.Items)
            {
                message += item.ToString() + "|";
            }
            mainForm.sendMessage(message);
            this.Close();
        }

        private void FrmGroup_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in mainListBox.Items)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
    }
}
