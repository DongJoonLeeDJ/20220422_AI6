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

        private void button_parking_Click(object sender, EventArgs e)
        {
            WriteLog("주차버튼 클릭");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            WriteLog("출차버튼 클릭");
        }
        private void WriteLog(string contents)
        {
            //$랑 쌍따옴표(") 이용시
            //문자열 안에 변수나 숫자 등의 값을 더하기 없이도 쉽게 넣을 수 있음
            string logContents
                = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}]{contents}";
            DataManager.printLog(logContents);
            //listBox_log.Items.Add(logContents); //최신 내용이 아래로
            listBox_log.Items.Insert(0, logContents); //최신내용이 위로
            //참고로 텍스트 파일은 어차피 최신 내용이 맨 아래로 가있다...
        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //내가 클릭한 행(=row)의 데이터들을
                //ParkingCar로 형변환한 것(as = 형변환 키워드)
                ParkingCar car 
                    = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.carNumber;
                textBox_driverName.Text = car.driverName;
                textBox_phoneNumber.Text = car.phoneNumber;

            }
            catch (Exception)
            {

            }
        }
    }
}
