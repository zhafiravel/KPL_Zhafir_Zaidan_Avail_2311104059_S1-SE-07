using System;
using System.Windows.Forms;

namespace tpmodul12_2311104059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method untuk mencari tanda bilangan
        private string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        // Event saat button ditekan
        private void btnProses_Click(object sender, EventArgs e)
        {
            int angka;
            if (int.TryParse(txtInput.Text, out angka))
            {
                string hasil = CariTandaBilangan(angka);
                lblHasil.Text = "Hasil: " + hasil;
            }
            else
            {
                lblHasil.Text = "Input tidak valid. Harap masukkan angka.";
            }
        }

        private void btnProses_Click_1(object sender, EventArgs e)
        {
            int inputAngka;
            if (int.TryParse(txtInput.Text, out inputAngka))
            {
                string hasil = CariTandaBilangan(inputAngka);
                lblHasil.Text = hasil;
            }
            else
            {
                lblHasil.Text = "Input tidak valid!";
            }
        }
    }
}
