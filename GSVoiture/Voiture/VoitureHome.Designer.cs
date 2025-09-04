namespace GSVoiture.Menu
{
    partial class VoitureHome
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            Nom = new DataGridViewTextBoxColumn();
            button3 = new Button();
            btnSupVoiture = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.adeauplast_logo_sticky;
            pictureBox1.Location = new Point(347, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 18F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(54, 251);
            button1.Name = "button1";
            button1.Size = new Size(254, 63);
            button1.TabIndex = 3;
            button1.Text = "Ajouter Voiture";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 18F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(330, 251);
            button2.Name = "button2";
            button2.Size = new Size(260, 63);
            button2.TabIndex = 4;
            button2.Text = "Modifier Voiture";
            button2.UseVisualStyleBackColor = false;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom });
            kryptonDataGridView1.Location = new Point(47, 355);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Size = new Size(834, 263);
            kryptonDataGridView1.TabIndex = 5;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_close_24;
            button3.Location = new Point(861, 7);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSupVoiture
            // 
            btnSupVoiture.BackColor = Color.White;
            btnSupVoiture.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 159);
            btnSupVoiture.FlatStyle = FlatStyle.Flat;
            btnSupVoiture.Font = new Font("MS UI Gothic", 18F);
            btnSupVoiture.ForeColor = Color.Black;
            btnSupVoiture.Location = new Point(613, 251);
            btnSupVoiture.Name = "btnSupVoiture";
            btnSupVoiture.Size = new Size(260, 63);
            btnSupVoiture.TabIndex = 7;
            btnSupVoiture.Text = "Supprimer Voiture";
            btnSupVoiture.UseVisualStyleBackColor = false;
            // 
            // VoitureHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSupVoiture);
            Controls.Add(button3);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "VoitureHome";
            Size = new Size(913, 701);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private DataGridViewTextBoxColumn Nom;
        private Button button3;
        private Button btnSupVoiture;
    }
}
