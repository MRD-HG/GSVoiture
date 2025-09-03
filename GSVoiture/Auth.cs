using System;
using GSVoiture.Menu;
namespace GSVoiture
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPage mn = new MenuPage();
            mn.Show();
            this.Hide();
        }
    }
}
