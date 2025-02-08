namespace NestQuest
{
    partial class Edit_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Profile));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txbFullNme = new TextBox();
            txbemail = new TextBox();
            txbpass = new TextBox();
            btnEdit = new Button();
            btnsave = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 107);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 194);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 255);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // txbFullNme
            // 
            txbFullNme.BackColor = SystemColors.AppWorkspace;
            txbFullNme.BorderStyle = BorderStyle.FixedSingle;
            txbFullNme.ForeColor = SystemColors.WindowFrame;
            txbFullNme.Location = new Point(253, 105);
            txbFullNme.Name = "txbFullNme";
            txbFullNme.Size = new Size(100, 23);
            txbFullNme.TabIndex = 7;
            txbFullNme.TextChanged += textBox1_TextChanged;
            // 
            // txbemail
            // 
            txbemail.BackColor = SystemColors.AppWorkspace;
            txbemail.BorderStyle = BorderStyle.FixedSingle;
            txbemail.ForeColor = SystemColors.WindowFrame;
            txbemail.Location = new Point(253, 194);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(100, 23);
            txbemail.TabIndex = 9;
            // 
            // txbpass
            // 
            txbpass.BackColor = SystemColors.AppWorkspace;
            txbpass.BorderStyle = BorderStyle.FixedSingle;
            txbpass.ForeColor = SystemColors.WindowFrame;
            txbpass.Location = new Point(253, 253);
            txbpass.Name = "txbpass";
            txbpass.Size = new Size(127, 23);
            txbpass.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.AppWorkspace;
            btnEdit.Location = new Point(315, 394);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 35);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button1_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ControlDark;
            btnsave.Location = new Point(488, 394);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(124, 35);
            btnsave.TabIndex = 14;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 15;
            // 
            // Edit_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(633, 450);
            Controls.Add(panel1);
            Controls.Add(btnsave);
            Controls.Add(btnEdit);
            Controls.Add(txbpass);
            Controls.Add(txbemail);
            Controls.Add(txbFullNme);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Edit_Profile";
            Text = "Edit_Profile";
            Load += Edit_Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txbFullNme;
        private TextBox txbemail;
        private TextBox txbpass;
        private Button btnEdit;
        private Button btnsave;
        private Panel panel1;
    }
}