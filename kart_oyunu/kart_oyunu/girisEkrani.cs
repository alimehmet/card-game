using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kart_oyunu
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }       

        private void oyunButonu2x5_Click(object sender, EventArgs e)
        {
            oyunEkrani2x5 oyun2x5 = new oyunEkrani2x5();
            oyun2x5.Show();
            this.Hide();
        }

        private void oyunButonu3x6_Click(object sender, EventArgs e)
        {
            oyunEkrani3x6 oyun3x6 = new oyunEkrani3x6();
            oyun3x6.Show();
            this.Hide();
        }

        private void oyunButonu4x5_Click(object sender, EventArgs e)
        {
            oyunEkrani4x5 oyun4x5 = new oyunEkrani4x5();
            oyun4x5.Show();
            this.Hide();
        }

        private void cikisButonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
