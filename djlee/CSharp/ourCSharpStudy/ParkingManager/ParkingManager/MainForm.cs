using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label_now.Text
                = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");

            try
            {
                textBox_parkingSpot.Text 
                    = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carNumber.Text = DataManager.Cars[0].carNumber;
                textBox_driverName.Text = DataManager.Cars[0].driverName;
                textBox_phoneNumber.Text = DataManager.Cars[0].phoneNumber;


            }
            catch (Exception)
            {

            }
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;

        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text
                = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }
    }
}
