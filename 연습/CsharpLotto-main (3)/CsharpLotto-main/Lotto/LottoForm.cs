using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Json;
using System.Net;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Lotto
{

    public partial class LottoForm : Form
    {
        bool tagmove;
        int mvalX, mvalY;
        private void move_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
            tagmove = true;
            mvalX = e.X;
            mvalY = e.Y;
            }
        }
        private void move_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (tagmove == true)
            {
                this.SetDesktopLocation(MousePosition.X - mvalX, MousePosition.Y - mvalY);
            }
        }
        private void move_panel_MouseUp(object sender, MouseEventArgs e)
        {
            tagmove = false;
        }
        #region
        private string GetHttpLottoString(string strUri)
        {
            string strResponseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
            request.Method = "GET";

            //Request Timer : 20s
            request.Timeout = 20 * 1000;

            //receive Call
            using (HttpWebResponse hwr = (HttpWebResponse)request.GetResponse())
            {
                //Success Call
                if (hwr.StatusCode == HttpStatusCode.OK)
                {
                    Stream respStream = hwr.GetResponseStream();
                    using (StreamReader sr = new StreamReader(respStream))
                    {
                        strResponseText = sr.ReadToEnd();
                    }
                }
                else
                {
                    strResponseText = "";
                }
            }

            return strResponseText;
        }

        private bool IsNullString(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        private int IsInt(object ob)
        {
            if (ob == null) return 0;

            int iCheck = 0;
            bool bCheck = int.TryParse(ob.ToString(), out iCheck);

            if (!bCheck)
            {
                return 0;
            }

            return iCheck;
        }
        #endregion

        int[] lotto_num = new int[7];
        int used_money = 0;
        int[] search_lotto_num = new int[7];

        public LottoForm()
        {
            InitializeComponent();

            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            num4.Text = "";
            num5.Text = "";
            num6.Text = "";
            bonus.Text = "";
            grade_number_label.Text = "NULL";
            match_bonus_num_label.Text = "NULL";
            match_num_label.Text = "NULL";
            num1.cornerRadius = 60;
            num2.cornerRadius = 60;
            num3.cornerRadius = 60;
            num4.cornerRadius = 60;
            num5.cornerRadius = 60;
            num6.cornerRadius = 60;
            bonus.cornerRadius = 60;

            num1.borderWidth = 2;
            num2.borderWidth = 2;
            num3.borderWidth = 2;
            num4.borderWidth = 2;
            num5.borderWidth = 2;
            num6.borderWidth = 2;
            bonus.borderWidth = 2;

            num1.backColor = Color.White;
            num2.backColor = Color.White;
            num3.backColor = Color.White;
            num4.backColor = Color.White;
            num5.backColor = Color.White;
            num6.backColor = Color.White;
            bonus.backColor = Color.White;
            result_box.backColor = Color.White;
        }

        private void lotto_button_Click(object sender, EventArgs e)
        {
            lotto_num[0] = new Random().Next(1, 46);

            for (int i = 1; i < 7; i++)
            {
                lotto_num[i] = new Random().Next(1, 46);

                if (lotto_num[i] == lotto_num[i - 1])
                {
                    i--;
                    continue;
                }
            }

            Array.Sort(lotto_num);

            if (lotto_num[0] <= 10)
            {
                num1.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[0] && lotto_num[0] <= 20)
            {
                num1.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[0] && lotto_num[0] <= 30)
            {
                num1.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[0] && lotto_num[0] <= 40)
            {
                num1.borderColor = Color.Black;
            }
            else
            {
                num1.borderColor = Color.Green;
            }


            if (lotto_num[1] <= 10)
            {
                num2.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[1] && lotto_num[1] <= 20)
            {
                num2.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[1] && lotto_num[1] <= 30)
            {
                num2.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[1] && lotto_num[1] <= 40)
            {
                num2.borderColor = Color.Black;
            }
            else
            {
                num2.borderColor = Color.Green;
            }

            if (lotto_num[2] <= 10)
            {
                num3.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[2] && lotto_num[2] <= 20)
            {
                num3.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[2] && lotto_num[2] <= 30)
            {
                num3.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[2] && lotto_num[2] <= 40)
            {
                num3.borderColor = Color.Black;
            }
            else
            {
                num3.borderColor = Color.Green;
            }

            if (lotto_num[3] <= 10)
            {
                num4.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[3] && lotto_num[3] <= 20)
            {
                num4.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[3] && lotto_num[3] <= 30)
            {
                num4.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[3] && lotto_num[3] <= 40)
            {
                num4.borderColor = Color.Black;
            }
            else
            {
                num4.borderColor = Color.Green;
            }

            if (lotto_num[4] <= 10)
            {
                num5.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[4] && lotto_num[4] <= 20)
            {
                num5.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[4] && lotto_num[4] <= 30)
            {
                num5.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[4] && lotto_num[4] <= 40)
            {
                num5.borderColor = Color.Black;
            }
            else
            {
                num5.borderColor = Color.Green;
            }

            if (lotto_num[5] <= 10)
            {
                num6.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[5] && lotto_num[5] <= 20)
            {
                num6.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[5] && lotto_num[5] <= 30)
            {
                num6.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[5] && lotto_num[5] <= 40)
            {
                num6.borderColor = Color.Black;
            }
            else
            {
                num6.borderColor = Color.Green;
            }

            if (lotto_num[6] <= 10)
            {
                bonus.borderColor = Color.Yellow;
            }
            else if (11 <= lotto_num[6] && lotto_num[6] <= 20)
            {
                bonus.borderColor = Color.Blue;
            }
            else if (21 <= lotto_num[6] && lotto_num[6] <= 30)
            {
                bonus.borderColor = Color.Red;
            }
            else if (31 <= lotto_num[6] && lotto_num[6] <= 40)
            {
                bonus.borderColor = Color.Black;
            }
            else
            {
                bonus.borderColor = Color.Green;
            }

            num1.Text = lotto_num[0].ToString();
            num2.Text = lotto_num[1].ToString();
            num3.Text = lotto_num[2].ToString();
            num4.Text = lotto_num[3].ToString();
            num5.Text = lotto_num[4].ToString();
            num6.Text = lotto_num[5].ToString();
            bonus.Text = lotto_num[6].ToString();

            used_money += 1000;
            money_label.Text = used_money.ToString();

            int match_num = 0;
            int bonus_num = 0;

            if (lotto_num[6] == search_lotto_num[6])
            {
                bonus_num = 1;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (lotto_num[i] == search_lotto_num[j])
                    {
                        match_num++;
                    }
                }
            }
            switch (match_num)
            {
                case 6:
                    grade_number_label.Text = "1등";
                    break;
                case 5:
                    if (bonus_num == 1)
                    {
                        grade_number_label.Text = "2등";
                    }
                    else
                    {
                        grade_number_label.Text = "3등";
                    }
                    break;
                case 4:
                    grade_number_label.Text = "4등";
                    break;
                case 3:
                    grade_number_label.Text = "5등";
                    break;
                default:
                    grade_number_label.Text = "꽝";
                    break;
            }
            match_num_label.Text = match_num.ToString() + "개";
            match_bonus_num_label.Text = bonus_num.ToString() + "개";


        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //If Null
            if (IsNullString(search_number_box.Text))
            {
                MessageBox.Show("Empty Value");
                return;
            }

            //If No Number
            if (IsInt(search_number_box.Text) == 0)
            {
                MessageBox.Show("Non-Number Included");
                return;
            }

            //Calling Lotto Number
            string strReturnValue = GetHttpLottoString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + search_number_box.Text);

            //If Fail Load
            if (strReturnValue == "")
            {
                MessageBox.Show("Fail Load");
                return;
            }

            //Convert Json
            JsonTextParser jtr = new JsonTextParser();
            JsonObject jo = jtr.Parse(strReturnValue);

            JsonObjectCollection jac = (JsonObjectCollection)jo;

            //If Success Load
            result_box.Text = "";
            if (jac["returnValue"].GetValue().ToString() == "success")
            {
                result_box.Text = " " + jac["drwtNo1"].GetValue().ToString()
                               + "," + jac["drwtNo2"].GetValue().ToString()
                               + "," + jac["drwtNo3"].GetValue().ToString()
                               + "," + jac["drwtNo4"].GetValue().ToString()
                               + "," + jac["drwtNo5"].GetValue().ToString()
                               + "," + jac["drwtNo6"].GetValue().ToString()
                               + "+" + jac["bnusNo"].GetValue().ToString();
            }
            else
            {
                MessageBox.Show(search_number_box.Text + " round is not exist");
                return;
            }

            search_lotto_num[0] = Convert.ToInt32(jac["drwtNo1"].GetValue());
            search_lotto_num[1] = Convert.ToInt32(jac["drwtNo2"].GetValue());
            search_lotto_num[2] = Convert.ToInt32(jac["drwtNo3"].GetValue());
            search_lotto_num[3] = Convert.ToInt32(jac["drwtNo4"].GetValue());
            search_lotto_num[4] = Convert.ToInt32(jac["drwtNo5"].GetValue());
            search_lotto_num[5] = Convert.ToInt32(jac["drwtNo6"].GetValue());
            search_lotto_num[6] = Convert.ToInt32(jac["bnusNo"].GetValue());
        }
        private void search_number_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        private void search_number_box_KeyDown(object sender, KeyEventArgs e)
        {
            //Press Enter Key
            if (e.KeyCode == Keys.Enter)
            {
                this.search_button_Click(sender, e);
            }
            if (e.KeyCode == Keys.Space)
            {
                this.lotto_button_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.close_button_Click(sender, e);
            }
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void mid_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void result_box_Click(object sender, EventArgs e)
        {

        }

        private void fixed_label2_Click(object sender, EventArgs e)
        {

        }

        private void search_number_box_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

