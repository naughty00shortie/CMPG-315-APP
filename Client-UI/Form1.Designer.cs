namespace Client_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            btnOpenChat = new Round_Button();
            panel3 = new Panel();
            btnOpenGroup = new Round_Button();
            btnCreatGroup = new Round_Button();
            label3 = new Label();
            listBox3 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            round_Button1 = new Round_Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 418);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 23);
            textBox2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(535, 334);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 3);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 14;
            label2.Text = "People Online";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 184);
            listBox1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnOpenChat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(565, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 293);
            panel1.TabIndex = 15;
            // 
            // btnOpenChat
            // 
            btnOpenChat.BackColor = Color.MediumSlateBlue;
            btnOpenChat.BackgroundColor = Color.MediumSlateBlue;
            btnOpenChat.BorderColor = Color.PaleVioletRed;
            btnOpenChat.BorderRadius = 40;
            btnOpenChat.BorderSize = 0;
            btnOpenChat.FlatAppearance.BorderSize = 0;
            btnOpenChat.FlatStyle = FlatStyle.Flat;
            btnOpenChat.ForeColor = Color.White;
            btnOpenChat.Location = new Point(40, 217);
            btnOpenChat.Name = "btnOpenChat";
            btnOpenChat.Size = new Size(105, 56);
            btnOpenChat.TabIndex = 15;
            btnOpenChat.Text = "Open Chat";
            btnOpenChat.TextColor = Color.White;
            btnOpenChat.UseVisualStyleBackColor = false;
            btnOpenChat.Click += btnOpenChat_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnOpenGroup);
            panel3.Controls.Add(btnCreatGroup);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(listBox3);
            panel3.Location = new Point(797, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 293);
            panel3.TabIndex = 17;
            // 
            // btnOpenGroup
            // 
            btnOpenGroup.BackColor = Color.MediumSlateBlue;
            btnOpenGroup.BackgroundColor = Color.MediumSlateBlue;
            btnOpenGroup.BorderColor = Color.PaleVioletRed;
            btnOpenGroup.BorderRadius = 40;
            btnOpenGroup.BorderSize = 0;
            btnOpenGroup.FlatAppearance.BorderSize = 0;
            btnOpenGroup.FlatStyle = FlatStyle.Flat;
            btnOpenGroup.ForeColor = Color.White;
            btnOpenGroup.Location = new Point(4, 223);
            btnOpenGroup.Name = "btnOpenGroup";
            btnOpenGroup.Size = new Size(84, 45);
            btnOpenGroup.TabIndex = 21;
            btnOpenGroup.Text = "Open Group";
            btnOpenGroup.TextColor = Color.White;
            btnOpenGroup.UseVisualStyleBackColor = false;
            btnOpenGroup.Click += btnOpenGroup_Click;
            // 
            // btnCreatGroup
            // 
            btnCreatGroup.BackColor = Color.MediumSlateBlue;
            btnCreatGroup.BackgroundColor = Color.MediumSlateBlue;
            btnCreatGroup.BorderColor = Color.PaleVioletRed;
            btnCreatGroup.BorderRadius = 40;
            btnCreatGroup.BorderSize = 0;
            btnCreatGroup.FlatAppearance.BorderSize = 0;
            btnCreatGroup.FlatStyle = FlatStyle.Flat;
            btnCreatGroup.ForeColor = Color.White;
            btnCreatGroup.Location = new Point(94, 223);
            btnCreatGroup.Name = "btnCreatGroup";
            btnCreatGroup.Size = new Size(84, 45);
            btnCreatGroup.TabIndex = 21;
            btnCreatGroup.Text = "Create Group";
            btnCreatGroup.TextColor = Color.White;
            btnCreatGroup.UseVisualStyleBackColor = false;
            btnCreatGroup.Click += btnCreatGroup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 4);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "Groups";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Global" });
            listBox3.Location = new Point(32, 27);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(118, 184);
            listBox3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 18;
            label4.Text = "Connected as:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 31);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 19;
            label5.Text = "Chatting in: Global";
            // 
            // round_Button1
            // 
            round_Button1.BackColor = Color.MediumSlateBlue;
            round_Button1.BackgroundColor = Color.MediumSlateBlue;
            round_Button1.BorderColor = Color.PaleVioletRed;
            round_Button1.BorderRadius = 40;
            round_Button1.BorderSize = 0;
            round_Button1.FlatAppearance.BorderSize = 0;
            round_Button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            round_Button1.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            round_Button1.FlatStyle = FlatStyle.Flat;
            round_Button1.ForeColor = Color.White;
            round_Button1.Location = new Point(470, 409);
            round_Button1.Name = "round_Button1";
            round_Button1.Size = new Size(84, 38);
            round_Button1.TabIndex = 20;
            round_Button1.Text = "Send";
            round_Button1.TextColor = Color.White;
            round_Button1.UseVisualStyleBackColor = false;
            round_Button1.Click += round_Button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1013, 481);
            Controls.Add(round_Button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label2;
        private ListBox listBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private ListBox listBox3;
        private Label label4;
        private Label label5;
        private Round_Button round_Button1;
        private Round_Button btnOpenChat;
        private Round_Button btnOpenGroup;
        private Round_Button btnCreatGroup;
    }
}