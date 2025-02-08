namespace NestQuest
{
    partial class OwnerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerDashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txbtitle = new TextBox();
            txbprice = new TextBox();
            txbarea = new TextBox();
            txbdes = new TextBox();
            txbcreat = new TextBox();
            txbloca = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 452);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 35);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.Orange;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 403);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(200, 49);
            button3.TabIndex = 2;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Orange;
            button2.Location = new Point(0, 358);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 1;
            button2.Text = "Edit profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(0, 299);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(200, 52);
            button1.TabIndex = 0;
            button1.Text = "Show Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(532, 162);
            dataGridView1.TabIndex = 1;
            // 
            // txbtitle
            // 
            txbtitle.Location = new Point(256, 176);
            txbtitle.Name = "txbtitle";
            txbtitle.Size = new Size(100, 23);
            txbtitle.TabIndex = 2;
            // 
            // txbprice
            // 
            txbprice.Location = new Point(256, 218);
            txbprice.Name = "txbprice";
            txbprice.Size = new Size(100, 23);
            txbprice.TabIndex = 3;
            // 
            // txbarea
            // 
            txbarea.Location = new Point(256, 259);
            txbarea.Name = "txbarea";
            txbarea.Size = new Size(100, 23);
            txbarea.TabIndex = 4;
            // 
            // txbdes
            // 
            txbdes.Location = new Point(544, 176);
            txbdes.Name = "txbdes";
            txbdes.Size = new Size(162, 23);
            txbdes.TabIndex = 5;
            // 
            // txbcreat
            // 
            txbcreat.Location = new Point(544, 215);
            txbcreat.Name = "txbcreat";
            txbcreat.Size = new Size(162, 23);
            txbcreat.TabIndex = 6;
            // 
            // txbloca
            // 
            txbloca.Location = new Point(544, 254);
            txbloca.Name = "txbloca";
            txbloca.Size = new Size(100, 23);
            txbloca.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 176);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 179);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 218);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 254);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 12;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 218);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "CreatedAt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 262);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 318);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 15;
            label7.Text = "Is Available";
            // 
            // button4
            // 
            button4.Location = new Point(591, 390);
            button4.Name = "button4";
            button4.Size = new Size(115, 41);
            button4.TabIndex = 16;
            button4.Text = "Add Prop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(393, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // OwnerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(728, 452);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbloca);
            Controls.Add(txbcreat);
            Controls.Add(txbdes);
            Controls.Add(txbarea);
            Controls.Add(txbprice);
            Controls.Add(txbtitle);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "OwnerDashboard";
            Text = "OwnerDashboard";
            Load += OwnerDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txbtitle;
        private TextBox txbprice;
        private TextBox txbarea;
        private TextBox txbdes;
        private TextBox txbcreat;
        private TextBox txbloca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private ComboBox comboBox1;
    }
}