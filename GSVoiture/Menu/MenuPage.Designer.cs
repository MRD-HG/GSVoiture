namespace GSVoiture.Menu
{
    partial class MenuPage
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            documentVoiture1 = new GSVoiture.Document.DocumentVoiture();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 159);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 701);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 206, 50);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15.75F);
            button4.ForeColor = Color.FromArgb(0, 79, 159);
            button4.Location = new Point(0, 282);
            button4.Name = "button4";
            button4.Size = new Size(201, 60);
            button4.TabIndex = 4;
            button4.Text = "Maintenance";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 206, 50);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F);
            button3.ForeColor = Color.FromArgb(0, 79, 159);
            button3.Location = new Point(0, 206);
            button3.Name = "button3";
            button3.Size = new Size(201, 60);
            button3.TabIndex = 3;
            button3.Text = "Documents";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 206, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F);
            button2.ForeColor = Color.FromArgb(0, 79, 159);
            button2.Location = new Point(0, 357);
            button2.Name = "button2";
            button2.Size = new Size(201, 60);
            button2.TabIndex = 2;
            button2.Text = "Alerts";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 206, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.ForeColor = Color.FromArgb(0, 79, 159);
            button1.Location = new Point(0, 128);
            button1.Name = "button1";
            button1.Size = new Size(201, 60);
            button1.TabIndex = 1;
            button1.Text = "Voiture";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 206, 50);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 0;
            label1.Text = "GS Voiture";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.adeauplast_logo_sticky;
            pictureBox1.Location = new Point(544, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // documentVoiture1
            // 
            documentVoiture1.BackColor = Color.White;
            documentVoiture1.Location = new Point(200, 2);
            documentVoiture1.Name = "documentVoiture1";
            documentVoiture1.Size = new Size(913, 701);
            documentVoiture1.TabIndex = 2;
            documentVoiture1.Visible = false;
            documentVoiture1.Load += documentVoiture1_Load;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 701);
            Controls.Add(documentVoiture1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Document.DocumentVoiture documentVoiture1;
    }
}