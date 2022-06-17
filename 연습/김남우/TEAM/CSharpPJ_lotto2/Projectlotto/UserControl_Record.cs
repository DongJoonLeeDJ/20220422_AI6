using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPJ_lotto
{
    public partial class UserControl_Record : UserControl
    {
        public UserControl_Record()
        {
            InitializeComponent();

            //pictureBox1.Load(@"../../../material/화면 캡처 2022-06-16 154738.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameResult.do?method=byWin");
        }
    }
}
