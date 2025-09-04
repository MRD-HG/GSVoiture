using GSVoiture.Voiture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSVoiture.Menu
{
    public partial class VoitureHome : UserControl
    {
        public VoitureHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterVoiture ajouterVoiture = new AjouterVoiture();
            ajouterVoiture.Show();
                }
    }
}
