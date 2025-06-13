using System;
using System.Windows.Forms;

namespace TJ13_2311104059
{
    public partial class Form1 : Form
    {
        private WeatherStation weatherStation;
        private DisplayDevice display1;
        private DisplayDevice display2;

        public Form1()
        {
            InitializeComponent();

            weatherStation = new WeatherStation();
            display1 = new DisplayDevice("Display 1", listBoxOutput);
            display2 = new DisplayDevice("Display 2", listBoxOutput);

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtSuhu.Text, out float suhu))
            {
                weatherStation.SetTemperature(suhu);
            }
            else
            {
                MessageBox.Show("Masukkan suhu yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
