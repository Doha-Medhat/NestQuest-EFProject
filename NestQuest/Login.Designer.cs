namespace NestQuest
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tx_email = new TextBox();
            tx_pass = new TextBox();
            btn_register = new Button();
            btn_login = new Button();
            Elabel = new Label();
            Plabel = new Label();
            SuspendLayout();
            // 
            // tx_email
            // 
            tx_email.Location = new Point(394, 68);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(135, 23);
            tx_email.TabIndex = 0;
            // 
            // tx_pass
            // 
            tx_pass.Location = new Point(394, 122);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(135, 23);
            tx_pass.TabIndex = 1;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(322, 232);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(84, 34);
            btn_register.TabIndex = 2;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(473, 232);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 34);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Elabel
            // 
            Elabel.AutoSize = true;
            Elabel.Location = new Point(322, 68);
            Elabel.Name = "Elabel";
            Elabel.Size = new Size(36, 15);
            Elabel.TabIndex = 4;
            Elabel.Text = "Email";
            // 
            // Plabel
            // 
            Plabel.AutoSize = true;
            Plabel.Location = new Point(322, 122);
            Plabel.Name = "Plabel";
            Plabel.Size = new Size(56, 15);
            Plabel.TabIndex = 5;
            Plabel.Text = "Passward";
            Plabel.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 475);
            Controls.Add(Plabel);
            Controls.Add(Elabel);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(tx_pass);
            Controls.Add(tx_email);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_email;
        private TextBox tx_pass;
        private Button btn_register;
        private Button btn_login;
        private Label Elabel;
        private Label Plabel;
    }
}