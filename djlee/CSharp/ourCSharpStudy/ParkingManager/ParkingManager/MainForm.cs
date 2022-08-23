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

                textBox_findNum.Text = textBox_parkingSpot.Text;

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
            //WriteLog("주차버튼 클릭");

            //양 옆의 공백 제거 : Trim
            if (textBox_parkingSpot.Text.Trim()=="")
                MessageBox.Show("주차 공간을 입력하세요(주차)");
            else if(textBox_carNumber.Text.Trim()=="")
                MessageBox.Show("차량 번호를 입력해주세요.");
            else
            {
                try
                {
                    //Single
                    //괄호 안에 조건을 적고, List에서 해당하는 조건을 갖는
                    //객체의 위치를 가져오는 것(얕은 복사 Shallow Copy)
                    ParkingCar car =
                        DataManager.Cars.Single
                        (x => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    //x : Cars 안에 들어 있는 객체들


                    //쉽게 정리 : Single 통해서 가져온 객체는, 변경되면, 원본에도 영향준다.

                    if (car.carNumber.Trim() != "")
                        MessageBox.Show("해당 공간엔 이미 차가 있습니다");
                    else
                    {
                        //car는 Single로 인해 해당 조건이 맞는 객체와 연결됨
                        //이를 참조개념 내지는 참조변수라고 한다.(참조복사)
                        //car에 있는 내용 변경시 Cars에 있는 내용이 바뀐다.
                        car.carNumber = textBox_carNumber.Text;
                        car.driverName = textBox_driverName.Text;
                        car.phoneNumber = textBox_phoneNumber.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;


                        //깊은 복사
                        //복사하고 난 뒤 복사본이 바뀌어도 원본이 영향받지 않음
                        //int a = 100;
                        //int b =a;
                        //b=500; //이렇게 하면 a엔 100, b엔 500이 들어가 있다.

                        //얕은 복사
                        //복사하고 난 뒤 복사본이 바뀌면 원본이 바뀜
                        //왜냐면 원본 내용을 복사한 게 아니고 그 원본의 위치를 가져온거라 그렇다.
                        //Student a = new Student();
                        //a.hakbeon = 5;
                        //Student b = a;
                        //b.hakbeon = 10;
                        //이럴 경우 a와 b 둘 다 학번값이 10이 된다.


                        DataManager.Save
                            (textBox_parkingSpot.Text, textBox_carNumber.Text,
                            textBox_driverName.Text, textBox_phoneNumber.Text);

                        string contents = $"주차공간{textBox_parkingSpot.Text}에 " +
                            $"{textBox_carNumber.Text}차를 주차했습니다.";

                        WriteLog(contents);
                        MessageBox.Show(contents);


                    }




                }
                catch (Exception)
                {
                    MessageBox.Show($"주차 공간 {textBox_parkingSpot.Text}은/는 없습니다.");
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "")
                MessageBox.Show("주차 공간을 입력하세요(출차)");
            else
            {
                try
                {
                    ParkingCar car =
                        DataManager.Cars.Single
                        (x => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);

                    if (car.carNumber.Trim() == "")
                        MessageBox.Show("해당 공간엔 아직 차가 없습니다.");
                    else
                    {
                        string oldCar = car.carNumber; //기존 차
                        car.carNumber = "";
                        car.driverName = "";
                        car.phoneNumber = "";
                        car.parkingTime = new DateTime();

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save
                            (textBox_parkingSpot.Text, "", "", "",true);

                        string contents = $"주차공간{textBox_parkingSpot.Text}에 " +
                            $"{oldCar}차를 출차했습니다.";

                        WriteLog(contents);
                        MessageBox.Show(contents);


                    }




                }
                catch (Exception)
                {
                    MessageBox.Show($"주차 공간 {textBox_parkingSpot.Text}은/는 없습니다.");
                }
            }
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

                textBox_findNum.Text = textBox_parkingSpot.Text;
                //textBox_findNum.Text = car.ParkingSpot.ToString();

            }
            catch (Exception)
            {

            }
        }

        //Cars 리스트에서 매개변수인 parkingSpot에 해당하는
        //공간 정보 찾아내는 것
        //Single 말고 foreach문으로 찾아내는 것
        private string lookUpParkingSpot(int parkingSpot)
        {
            string parkedCarNum = ""; //주차된 차 넘버
            try
            {
                foreach (var item in DataManager.Cars)
                {
                    if(item.ParkingSpot==parkingSpot)
                    {
                        parkedCarNum = item.carNumber;
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
            return parkedCarNum; //해당 공간에 차가 없으면 ""을 반환할 것
        }

        //해당 공간 정보를 메시지 박스로 띄움
        //여기선 select문 안 쓰고 그냥 Cars에서 바로 찾을 것
        private void button_find_Click(object sender, EventArgs e)
        {
            try
            {
                int parkingSpot = int.Parse(textBox_findNum.Text);
                string parkingCar = lookUpParkingSpot(parkingSpot);
                string contents = "";
                if (parkingCar.Trim() != "")
                {
                    contents = $"주차공간 {parkingSpot}에 " +
                        $"주차된 차는 {parkingCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {parkingSpot}에 차가 없습니다.";
                }
                WriteLog(contents);
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //db에서 다시 읽어오는 것
        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        //주차공간을 추가하거나 삭제하는 메소드
        //parkingSpot - 공간번호
        //command - 삭제 혹은 추가 내용
        private void spot_add_delete(string parkingSpot, string command)
        {
            //TryParse : int.Parse랑 try catch를 합친 것
            //첫번째 매개변수가 "123" 이런식으로 숫자로 변환이 가능한 거면
            //pSpot이라는 변수 선언하고, 그 변수에 숫자 넣음
            //그리고 TryParse라는 이 메소드는 true를 리턴함
            //만약에 공백이거나 엉뚱한 값을 입력하면 pSpot에 0이 들어가고
            //TryParse라는 메소드는 false값을 리턴함

            parkingSpot = parkingSpot.Trim(); //공백제거 후 진행
            int.TryParse(parkingSpot, out int pSpot);
            if(pSpot <=0)
            {
                WriteLog("주차 공간 번호는 0 이상의 숫자여야 합니다.");
                MessageBox.Show("주차 공간 번호는 0 이상의 숫자여야 합니다.");
                return; //이벤트(=메소드) 종료
            }
            string contents = ""; //로그에 집어넣을 컨텐츠

            //DataManager에 Save라는 메소드를 추가하는 데,
            //기존에 만들었던 Save는 주차/출차용
            //지금 만들 건 주차공간 추가/삭제용
            bool check = DataManager.Save(command, parkingSpot, out contents);
            //check 주차공간이 성공적으로 추가/삭제될 경우
            //만약 주차공간이 이미 있는 데 추가하거나 없는 걸 삭제하려고 할 경우엔
            //전체 갱신 버튼을 누를 필요 없음
            if (check)
                button_refresh.PerformClick(); //전체 갱신 버튼 누르기
            MessageBox.Show(contents);
            WriteLog(contents);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            spot_add_delete(textBox_findNum.Text, "insert");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            spot_add_delete(textBox_findNum.Text, "delete");
        }
    }
}
