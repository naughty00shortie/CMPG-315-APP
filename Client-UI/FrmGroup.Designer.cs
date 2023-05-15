namespace Client_UI
{
    partial class FrmGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnAddToGroup = new Round_Button();
            btnRemoveFromGroup = new Round_Button();
            btnCreateGroup = new Round_Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(143, 199);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(11, 23);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(143, 199);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Available People";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 5);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "People in group";
            label2.Click += label2_Click;
            // 
            // btnAddToGroup
            // 
            btnAddToGroup.BackColor = Color.MediumSlateBlue;
            btnAddToGroup.BackgroundColor = Color.MediumSlateBlue;
            btnAddToGroup.BorderColor = Color.PaleVioletRed;
            btnAddToGroup.BorderRadius = 40;
            btnAddToGroup.BorderSize = 0;
            btnAddToGroup.FlatAppearance.BorderSize = 0;
            btnAddToGroup.FlatStyle = FlatStyle.Flat;
            btnAddToGroup.ForeColor = Color.White;
            btnAddToGroup.Location = new Point(240, 75);
            btnAddToGroup.Name = "btnAddToGroup";
            btnAddToGroup.Size = new Size(53, 48);
            btnAddToGroup.TabIndex = 7;
            btnAddToGroup.Text = ">";
            btnAddToGroup.TextColor = Color.White;
            btnAddToGroup.UseVisualStyleBackColor = false;
            btnAddToGroup.Click += btnAddToGroup_Click;
            // 
            // btnRemoveFromGroup
            // 
            btnRemoveFromGroup.BackColor = Color.MediumSlateBlue;
            btnRemoveFromGroup.BackgroundColor = Color.MediumSlateBlue;
            btnRemoveFromGroup.BorderColor = Color.PaleVioletRed;
            btnRemoveFromGroup.BorderRadius = 40;
            btnRemoveFromGroup.BorderSize = 0;
            btnRemoveFromGroup.FlatAppearance.BorderSize = 0;
            btnRemoveFromGroup.FlatStyle = FlatStyle.Flat;
            btnRemoveFromGroup.ForeColor = Color.White;
            btnRemoveFromGroup.Location = new Point(240, 145);
            btnRemoveFromGroup.Name = "btnRemoveFromGroup";
            btnRemoveFromGroup.Size = new Size(53, 48);
            btnRemoveFromGroup.TabIndex = 8;
            btnRemoveFromGroup.Text = "<";
            btnRemoveFromGroup.TextColor = Color.White;
            btnRemoveFromGroup.UseVisualStyleBackColor = false;
            btnRemoveFromGroup.Click += btnRemoveFromGroup_Click;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.MediumSlateBlue;
            btnCreateGroup.BackgroundColor = Color.MediumSlateBlue;
            btnCreateGroup.BorderColor = Color.PaleVioletRed;
            btnCreateGroup.BorderRadius = 40;
            btnCreateGroup.BorderSize = 0;
            btnCreateGroup.FlatAppearance.BorderSize = 0;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.ForeColor = Color.White;
            btnCreateGroup.Location = new Point(198, 286);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(131, 42);
            btnCreateGroup.TabIndex = 9;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.TextColor = Color.White;
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox2);
            panel1.Location = new Point(333, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 237);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(32, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 237);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 5);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "People online";
            // 
            // FrmGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(539, 355);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCreateGroup);
            Controls.Add(btnRemoveFromGroup);
            Controls.Add(btnAddToGroup);
            Controls.Add(label1);
            Name = "FrmGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGroup";
            Load += FrmGroup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Round_Button btnAddToGroup;
        private Round_Button btnRemoveFromGroup;
        private Round_Button btnCreateGroup;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
    }
}