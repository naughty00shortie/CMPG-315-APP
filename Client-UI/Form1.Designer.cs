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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenChat = new Client_UI.Round_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenGroup = new Client_UI.Round_Button();
            this.btnCreatGroup = new Client_UI.Round_Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.round_Button1 = new Client_UI.Round_Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(440, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(535, 334);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "People Online";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(32, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 242);
            this.listBox1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpenChat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(573, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 334);
            this.panel1.TabIndex = 15;
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenChat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenChat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenChat.BorderRadius = 40;
            this.btnOpenChat.BorderSize = 0;
            this.btnOpenChat.FlatAppearance.BorderSize = 0;
            this.btnOpenChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOpenChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenChat.ForeColor = System.Drawing.Color.White;
            this.btnOpenChat.Location = new System.Drawing.Point(45, 273);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(105, 56);
            this.btnOpenChat.TabIndex = 15;
            this.btnOpenChat.Text = "Open Chat";
            this.btnOpenChat.TextColor = System.Drawing.Color.White;
            this.btnOpenChat.UseVisualStyleBackColor = false;
            this.btnOpenChat.Click += new System.EventHandler(this.btnOpenChat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOpenGroup);
            this.panel3.Controls.Add(this.btnCreatGroup);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Location = new System.Drawing.Point(797, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 334);
            this.panel3.TabIndex = 17;
            // 
            // btnOpenGroup
            // 
            this.btnOpenGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenGroup.BorderRadius = 40;
            this.btnOpenGroup.BorderSize = 0;
            this.btnOpenGroup.FlatAppearance.BorderSize = 0;
            this.btnOpenGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOpenGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGroup.ForeColor = System.Drawing.Color.White;
            this.btnOpenGroup.Location = new System.Drawing.Point(3, 284);
            this.btnOpenGroup.Name = "btnOpenGroup";
            this.btnOpenGroup.Size = new System.Drawing.Size(84, 45);
            this.btnOpenGroup.TabIndex = 21;
            this.btnOpenGroup.Text = "Open Group";
            this.btnOpenGroup.TextColor = System.Drawing.Color.White;
            this.btnOpenGroup.UseVisualStyleBackColor = false;
            this.btnOpenGroup.Click += new System.EventHandler(this.btnOpenGroup_Click);
            // 
            // btnCreatGroup
            // 
            this.btnCreatGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreatGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreatGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreatGroup.BorderRadius = 40;
            this.btnCreatGroup.BorderSize = 0;
            this.btnCreatGroup.FlatAppearance.BorderSize = 0;
            this.btnCreatGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCreatGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatGroup.ForeColor = System.Drawing.Color.White;
            this.btnCreatGroup.Location = new System.Drawing.Point(100, 284);
            this.btnCreatGroup.Name = "btnCreatGroup";
            this.btnCreatGroup.Size = new System.Drawing.Size(84, 45);
            this.btnCreatGroup.TabIndex = 21;
            this.btnCreatGroup.Text = "Create Group";
            this.btnCreatGroup.TextColor = System.Drawing.Color.White;
            this.btnCreatGroup.UseVisualStyleBackColor = false;
            this.btnCreatGroup.Click += new System.EventHandler(this.btnCreatGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Groups";
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Items.AddRange(new object[] {
            "Global"});
            this.listBox3.Location = new System.Drawing.Point(32, 27);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(118, 242);
            this.listBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Connected as:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chatting in: Global";
            // 
            // round_Button1
            // 
            this.round_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.round_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.round_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.round_Button1.BorderRadius = 40;
            this.round_Button1.BorderSize = 0;
            this.round_Button1.FlatAppearance.BorderSize = 0;
            this.round_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.round_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.round_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button1.ForeColor = System.Drawing.Color.White;
            this.round_Button1.Location = new System.Drawing.Point(463, 409);
            this.round_Button1.Name = "round_Button1";
            this.round_Button1.Size = new System.Drawing.Size(84, 38);
            this.round_Button1.TabIndex = 20;
            this.round_Button1.Text = "Send";
            this.round_Button1.TextColor = System.Drawing.Color.White;
            this.round_Button1.UseVisualStyleBackColor = false;
            this.round_Button1.Click += new System.EventHandler(this.round_Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 481);
            this.Controls.Add(this.round_Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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