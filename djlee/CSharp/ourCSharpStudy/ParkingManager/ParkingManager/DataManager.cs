using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars 
            = new List<ParkingCar>();

        //정적 생성자
        //딱 한 번만 불러오고
        //해당 클래스에 접근할 때 자동으로 불러와진다.
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear(); //Cars에 있는 내용 다 비움

                //selectQuery 통해서 dt에 값 넣었는 데
                //그걸 1줄씩 읽어들인다.
                foreach(DataRow item in DBHelper.dt.Rows)
                {
                    //ParkingCar 타입의 데이터 통해서 읽기
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot
                        = int.Parse(item["parkingSpot"].ToString());
                    car.carNumber = item["carNumber"].ToString();
                    car.driverName = item["driverName"].ToString();
                    car.phoneNumber = item["phoneNumber"].ToString();
                    car.parkingTime = item["parkingTime"].ToString() == "" ?
                        new DateTime() : 
                        DateTime.Parse(item["parkingTime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
               // throw;
            }
        }

    }
}
