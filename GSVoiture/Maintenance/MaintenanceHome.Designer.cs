namespace GSVoiture.Maintenance
{
    partial class MaintenanceHome
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
            label1 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            btnSupVoiture = new Button();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            Nom = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.SplitButton;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 206, 50);
            label1.Location = new Point(291, 135);
            label1.Name = "label1";
            label1.Size = new Size(309, 34);
            label1.TabIndex = 0;
            label1.Text = "Manage Maintenance";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_close_24;
            button3.Location = new Point(866, 2);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.adeauplast_logo_sticky;
            pictureBox1.Location = new Point(352, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnSupVoiture
            // 
            btnSupVoiture.BackColor = Color.White;
            btnSupVoiture.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            btnSupVoiture.FlatStyle = FlatStyle.Flat;
            btnSupVoiture.Font = new Font("MS UI Gothic", 18F);
            btnSupVoiture.ForeColor = Color.Black;
            btnSupVoiture.Location = new Point(591, 225);
            btnSupVoiture.Name = "btnSupVoiture";
            btnSupVoiture.Size = new Size(263, 45);
            btnSupVoiture.TabIndex = 14;
            btnSupVoiture.Text = "Supprimer Maintenance";
            btnSupVoiture.UseVisualStyleBackColor = false;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom });
            kryptonDataGridView1.Location = new Point(46, 407);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Size = new Size(834, 263);
            kryptonDataGridView1.TabIndex = 13;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 18F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(342, 225);
            button2.Name = "button2";
            button2.Size = new Size(237, 45);
            button2.TabIndex = 12;
            button2.Text = "Modifier Maintenance";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(85, 225);
            button1.Name = "button1";
            button1.Size = new Size(241, 45);
            button1.TabIndex = 11;
            button1.Text = "Ajouter Maintenance";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 368);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 373);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 16;
            label2.Text = "Tier par Voiture";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(312, 276);
            button4.Name = "button4";
            button4.Size = new Size(149, 45);
            button4.TabIndex = 17;
            button4.Text = "Ajouter Type";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(473, 276);
            button5.Name = "button5";
            button5.Size = new Size(155, 45);
            button5.TabIndex = 18;
            button5.Text = "Modifier Type";
            button5.UseVisualStyleBackColor = false;
            // 
            // MaintenanceHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(btnSupVoiture);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MaintenanceHome";
            Size = new Size(913, 701);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private PictureBox pictureBox1;
        private Button btnSupVoiture;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private DataGridViewTextBoxColumn Nom;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button4;
        private Button button5;
    }
}
