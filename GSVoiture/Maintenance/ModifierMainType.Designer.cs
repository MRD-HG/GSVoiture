namespace GSVoiture.MaintenanceType
{
    partial class ModifierMainType
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
            richTextBox1 = new RichTextBox();
            AjtVoiture = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(190, 427);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(211, 96);
            richTextBox1.TabIndex = 45;
            richTextBox1.Text = "";
            // 
            // AjtVoiture
            // 
            AjtVoiture.Cursor = Cursors.Hand;
            AjtVoiture.FlatStyle = FlatStyle.Flat;
            AjtVoiture.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AjtVoiture.Location = new Point(148, 578);
            AjtVoiture.Name = "AjtVoiture";
            AjtVoiture.Size = new Size(124, 40);
            AjtVoiture.TabIndex = 44;
            AjtVoiture.Text = "Modifier";
            AjtVoiture.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 12F);
            textBox4.Location = new Point(190, 335);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 35);
            textBox4.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(190, 264);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 35);
            textBox3.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label5.Location = new Point(15, 445);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 40;
            label5.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label3.Location = new Point(15, 333);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 39;
            label3.Text = "Fréquence(mois)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label2.Location = new Point(15, 267);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 38;
            label2.Text = "Fréquence(KM)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label1.Location = new Point(15, 201);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 37;
            label1.Text = "Nom";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_close_24;
            button3.Location = new Point(392, 12);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 36;
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 46;
            // 
            // ModifierMainType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(454, 638);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(AjtVoiture);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModifierMainType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifierMainType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button AjtVoiture;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private ComboBox comboBox1;
    }
}