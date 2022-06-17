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
    public partial class UserControl_Home : UserControl
    {
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=buyLotto");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=game520Method");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LI23");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LD20");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LD11");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LI21");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LI22");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LD10");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhlottery.co.kr/gameInfo.do?method=lottoMainView&lottoId=LD14");
        }

    }
}
