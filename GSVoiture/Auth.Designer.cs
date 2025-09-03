namespace GSVoiture
{
    partial class Auth
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.adeauplast_logo_sticky;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(97, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 332);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(78, 457);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(257, 47);
            textBox2.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel1.Location = new Point(73, 300);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(103, 29);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "Utilisateur";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            kryptonLabel2.Location = new Point(73, 422);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(130, 29);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Mot De Passe";
            kryptonLabel2.Click += kryptonLabel2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 582);
            button1.Name = "button1";
            button1.Size = new Size(129, 47);
            button1.TabIndex = 6;
            button1.Text = "Entre";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 680);
            Controls.Add(button1);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Button button1;
    }
}
