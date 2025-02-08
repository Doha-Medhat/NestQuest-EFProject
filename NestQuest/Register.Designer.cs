namespace NestQuest
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txb_fullname = new TextBox();
            txb_confirm = new TextBox();
            txb_Pass = new TextBox();
            txb_email = new TextBox();
            Lfullname = new Label();
            label2 = new Label();
            L_age = new Label();
            l_email = new Label();
            l_password = new Label();
            l_confirm = new Label();
            btn_register = new Button();
            tn_clear = new Button();
            combx_age = new ComboBox();
            cmb_role = new ComboBox();
            SuspendLayout();
            // 
            // txb_fullname
            // 
            txb_fullname.BackColor = SystemColors.ButtonShadow;
            txb_fullname.BorderStyle = BorderStyle.FixedSingle;
            txb_fullname.Location = new Point(12, 97);
            txb_fullname.Name = "txb_fullname";
            txb_fullname.Size = new Size(131, 23);
            txb_fullname.TabIndex = 0;
            // 
            // txb_confirm
            // 
            txb_confirm.BackColor = SystemColors.ButtonShadow;
            txb_confirm.BorderStyle = BorderStyle.FixedSingle;
            txb_confirm.Location = new Point(531, 264);
            txb_confirm.Name = "txb_confirm";
            txb_confirm.Size = new Size(189, 23);
            txb_confirm.TabIndex = 1;
            // 
            // txb_Pass
            // 
            txb_Pass.BackColor = SystemColors.ButtonShadow;
            txb_Pass.BorderStyle = BorderStyle.FixedSingle;
            txb_Pass.Location = new Point(531, 180);
            txb_Pass.Name = "txb_Pass";
            txb_Pass.Size = new Size(189, 23);
            txb_Pass.TabIndex = 2;
            // 
            // txb_email
            // 
            txb_email.BackColor = SystemColors.ButtonShadow;
            txb_email.BorderStyle = BorderStyle.FixedSingle;
            txb_email.Location = new Point(531, 97);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(189, 23);
            txb_email.TabIndex = 3;
            // 
            // Lfullname
            // 
            Lfullname.AutoSize = true;
            Lfullname.BackColor = SystemColors.ControlLight;
            Lfullname.Location = new Point(12, 79);
            Lfullname.Name = "Lfullname";
            Lfullname.Size = new Size(61, 15);
            Lfullname.TabIndex = 6;
            Lfullname.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "Who Are U";
            // 
            // L_age
            // 
            L_age.AutoSize = true;
            L_age.BackColor = SystemColors.ControlLight;
            L_age.Location = new Point(12, 246);
            L_age.Name = "L_age";
            L_age.Size = new Size(28, 15);
            L_age.TabIndex = 8;
            L_age.Text = "Age";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.BackColor = SystemColors.ControlLight;
            l_email.Location = new Point(531, 79);
            l_email.Name = "l_email";
            l_email.Size = new Size(36, 15);
            l_email.TabIndex = 9;
            l_email.Text = "Email";
            // 
            // l_password
            // 
            l_password.AutoSize = true;
            l_password.BackColor = SystemColors.ControlLight;
            l_password.Location = new Point(531, 162);
            l_password.Name = "l_password";
            l_password.Size = new Size(57, 15);
            l_password.TabIndex = 10;
            l_password.Text = "Password";
            // 
            // l_confirm
            // 
            l_confirm.AutoSize = true;
            l_confirm.BackColor = SystemColors.ControlLight;
            l_confirm.Location = new Point(531, 246);
            l_confirm.Name = "l_confirm";
            l_confirm.Size = new Size(104, 15);
            l_confirm.TabIndex = 11;
            l_confirm.Text = "Confirm Password";
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.ButtonShadow;
            btn_register.Location = new Point(444, 407);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(114, 47);
            btn_register.TabIndex = 12;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += button1_Click;
            // 
            // tn_clear
            // 
            tn_clear.BackColor = SystemColors.ButtonShadow;
            tn_clear.Location = new Point(171, 407);
            tn_clear.Name = "tn_clear";
            tn_clear.Size = new Size(108, 47);
            tn_clear.TabIndex = 13;
            tn_clear.Text = "Go To Login";
            tn_clear.UseVisualStyleBackColor = false;
            tn_clear.Click += tn_clear_Click;
            // 
            // combx_age
            // 
            combx_age.BackColor = SystemColors.ButtonShadow;
            combx_age.FormattingEnabled = true;
            combx_age.Location = new Point(12, 264);
            combx_age.Name = "combx_age";
            combx_age.Size = new Size(127, 23);
            combx_age.TabIndex = 14;
            // 
            // cmb_role
            // 
            cmb_role.BackColor = Color.DarkGray;
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(12, 180);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(121, 23);
            cmb_role.TabIndex = 15;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(729, 497);
            Controls.Add(cmb_role);
            Controls.Add(combx_age);
            Controls.Add(tn_clear);
            Controls.Add(btn_register);
            Controls.Add(l_confirm);
            Controls.Add(l_password);
            Controls.Add(l_email);
            Controls.Add(L_age);
            Controls.Add(label2);
            Controls.Add(Lfullname);
            Controls.Add(txb_email);
            Controls.Add(txb_Pass);
            Controls.Add(txb_confirm);
            Controls.Add(txb_fullname);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_fullname;
        private TextBox txb_confirm;
        private TextBox txb_Pass;
        private TextBox txb_email;
        private Label Lfullname;
        private Label label2;
        private Label L_age;
        private Label l_email;
        private Label l_password;
        private Label l_confirm;
        private Button btn_register;
        private Button tn_clear;
        private ComboBox combx_age;
        private ComboBox cmb_role;
    }
}