namespace GSVoiture.Voiture
{
    partial class AjouterVoiture
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            kryptonRadioButton1 = new Krypton.Toolkit.KryptonRadioButton();
            kryptonRadioButton2 = new Krypton.Toolkit.KryptonRadioButton();
            AjtVoiture = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_close_24;
            button3.Location = new Point(404, 3);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label1.Location = new Point(41, 177);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 8;
            label1.Text = "Marque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label2.Location = new Point(41, 241);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 9;
            label2.Text = "Modele";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label3.Location = new Point(41, 304);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 10;
            label3.Text = "Annee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label4.Location = new Point(41, 364);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 11;
            label4.Text = "Immatriculation";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label5.Location = new Point(41, 429);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 12;
            label5.Text = "Proprietaire";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label6.Location = new Point(41, 491);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 13;
            label6.Text = "Kilometrage Actuel";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label7.Location = new Point(41, 555);
            label7.Name = "label7";
            label7.Size = new Size(152, 21);
            label7.TabIndex = 14;
            label7.Text = "Date Mise EnService";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(216, 183);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 35);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(216, 422);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 35);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(216, 237);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 35);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 12F);
            textBox4.Location = new Point(216, 297);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 35);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 12F);
            textBox5.Location = new Point(216, 364);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "0000/أ/";
            textBox5.Size = new Size(211, 35);
            textBox5.TabIndex = 19;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 12F);
            textBox6.Location = new Point(216, 490);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(211, 35);
            textBox6.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(227, 554);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe MDL2 Assets", 15.75F);
            label8.Location = new Point(41, 623);
            label8.Name = "label8";
            label8.Size = new Size(49, 21);
            label8.TabIndex = 22;
            label8.Text = "Active";
            label8.Click += label8_Click;
            // 
            // kryptonRadioButton1
            // 
            kryptonRadioButton1.Location = new Point(157, 621);
            kryptonRadioButton1.Name = "kryptonRadioButton1";
            kryptonRadioButton1.Size = new Size(42, 20);
            kryptonRadioButton1.TabIndex = 23;
            kryptonRadioButton1.Values.Text = "Oui";
            // 
            // kryptonRadioButton2
            // 
            kryptonRadioButton2.Location = new Point(302, 619);
            kryptonRadioButton2.Name = "kryptonRadioButton2";
            kryptonRadioButton2.Size = new Size(46, 20);
            kryptonRadioButton2.TabIndex = 24;
            kryptonRadioButton2.Values.Text = "Non";
            // 
            // AjtVoiture
            // 
            AjtVoiture.Cursor = Cursors.Hand;
            AjtVoiture.FlatStyle = FlatStyle.Flat;
            AjtVoiture.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AjtVoiture.Location = new Point(173, 695);
            AjtVoiture.Name = "AjtVoiture";
            AjtVoiture.Size = new Size(124, 40);
            AjtVoiture.TabIndex = 25;
            AjtVoiture.Text = "Ajouter";
            AjtVoiture.UseVisualStyleBackColor = true;
            // 
            // AjouterVoiture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AjtVoiture);
            Controls.Add(kryptonRadioButton2);
            Controls.Add(kryptonRadioButton1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Name = "AjouterVoiture";
            Size = new Size(454, 763);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private Button AjtVoiture;
    }
}
