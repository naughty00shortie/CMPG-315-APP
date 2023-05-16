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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToGroup = new Client_UI.Round_Button();
            this.btnRemoveFromGroup = new Client_UI.Round_Button();
            this.btnCreateGroup = new Client_UI.Round_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(9, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 199);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(11, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 199);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "People in group";
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddToGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddToGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddToGroup.BorderRadius = 40;
            this.btnAddToGroup.BorderSize = 0;
            this.btnAddToGroup.FlatAppearance.BorderSize = 0;
            this.btnAddToGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAddToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddToGroup.Location = new System.Drawing.Point(240, 88);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(53, 48);
            this.btnAddToGroup.TabIndex = 7;
            this.btnAddToGroup.Text = ">";
            this.btnAddToGroup.TextColor = System.Drawing.Color.White;
            this.btnAddToGroup.UseVisualStyleBackColor = false;
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // btnRemoveFromGroup
            // 
            this.btnRemoveFromGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemoveFromGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemoveFromGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveFromGroup.BorderRadius = 40;
            this.btnRemoveFromGroup.BorderSize = 0;
            this.btnRemoveFromGroup.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRemoveFromGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromGroup.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromGroup.Location = new System.Drawing.Point(240, 172);
            this.btnRemoveFromGroup.Name = "btnRemoveFromGroup";
            this.btnRemoveFromGroup.Size = new System.Drawing.Size(53, 48);
            this.btnRemoveFromGroup.TabIndex = 8;
            this.btnRemoveFromGroup.Text = "<";
            this.btnRemoveFromGroup.TextColor = System.Drawing.Color.White;
            this.btnRemoveFromGroup.UseVisualStyleBackColor = false;
            this.btnRemoveFromGroup.Click += new System.EventHandler(this.btnRemoveFromGroup_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreateGroup.BorderRadius = 40;
            this.btnCreateGroup.BorderSize = 0;
            this.btnCreateGroup.FlatAppearance.BorderSize = 0;
            this.btnCreateGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.ForeColor = System.Drawing.Color.White;
            this.btnCreateGroup.Location = new System.Drawing.Point(198, 279);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(131, 42);
            this.btnCreateGroup.TabIndex = 9;
            this.btnCreateGroup.Text = "Create Group";
            this.btnCreateGroup.TextColor = System.Drawing.Color.White;
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Location = new System.Drawing.Point(333, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 237);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(32, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 237);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "People online";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(253, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(243, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Remove";
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.btnRemoveFromGroup);
            this.Controls.Add(this.btnAddToGroup);
            this.Controls.Add(this.label1);
            this.Name = "FrmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGroup";
            this.Load += new System.EventHandler(this.FrmGroup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label4;
        private Label label5;
    }
}