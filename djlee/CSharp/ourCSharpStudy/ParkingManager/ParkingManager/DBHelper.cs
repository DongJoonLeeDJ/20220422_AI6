using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    //데이터베이스에 직접 접근하는 클래스
    //데이터 넣고 빼고 수정하는 클래스
    //DataManager에서 사용하는 클래스
    //되도록이면 MainForm과 같은 화면에선
    //이 클래스를 직접 안 쓰는 게 좋다.
    //(MVC패턴처럼)
    public class DBHelper
    {
        //전부 static이 붙는 이유
        //메소드들이랑 객체들 모두 클래스명.메소드 혹은
        //클래스명.객체 이렇게 사용할거라서 그렇다.
        //new 등으로 인스턴스 만들 필요가 없으므로
        //(=DB 연결 객체가 하나면 되므로)
        //이렇게 한다.
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

    }
}
