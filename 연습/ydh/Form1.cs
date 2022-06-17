using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace project001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Text = "실행";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        Random r = new Random();
       int[] ar = new int[] {173,163,161,167,151,154,158,154,132,162,160,168,171,164,158,158,171,168
        ,153,166,160,130,141,162,149,164,173,143,138,151,160,142,169,176,155,156,163,161,167,163,141
        ,156,180,157,157};
        
        private int[] lot = new int[6];
        List<Lotto> mylottos = new List<Lotto>();
       
        int[] ar2 = new int[6];
        int num=0;
        int sum = 0;
        int start = 0;
        public void genLotto(int start)
        {
            {
                //https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=1000
                mylottos.Clear();
                int count = start;
                
                
                {
                    var json = new WebClient().DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                    
                    var jArray = JObject.Parse(json);
                     
                    Lotto l = new Lotto()
                    {
                        drwNo = jArray["drwNo"].ToString(),
                        drwNoDate = jArray["drwNoDate"].ToString(),
                        drwtNo1 = jArray["drwtNo1"].ToString(),
                        drwtNo2 = jArray["drwtNo2"].ToString(),
                        drwtNo3 = jArray["drwtNo3"].ToString(),
                        drwtNo4 = jArray["drwtNo4"].ToString(),
                        drwtNo5 = jArray["drwtNo5"].ToString(),
                        drwtNo6 = jArray["drwtNo6"].ToString(),
                        bnusNo = jArray["bnusNo"].ToString()
                    };
                    mylottos.Add(l);
                    
                    
                    }

                int n = 1;

                try
                {
                   
                    label10.Text = mylottos[mylottos.Count - n].drwtNo1;
                    label11.Text = mylottos[mylottos.Count - n].drwtNo2;
                    label12.Text = mylottos[mylottos.Count - n].drwtNo3;
                    label13.Text = mylottos[mylottos.Count - n].drwtNo4;
                    label14.Text = mylottos[mylottos.Count - n].drwtNo5;
                    label15.Text = mylottos[mylottos.Count - n].drwtNo6;
                    label16.Text = mylottos[mylottos.Count - n].bnusNo;

                    lot[0] = int.Parse(mylottos[mylottos.Count - n].drwtNo1);
                    lot[1] = int.Parse(mylottos[mylottos.Count - n].drwtNo2);
                    lot[2] = int.Parse(mylottos[mylottos.Count - n].drwtNo3);
                    lot[3] = int.Parse(mylottos[mylottos.Count - n].drwtNo4);
                    lot[4] = int.Parse(mylottos[mylottos.Count - n].drwtNo5);
                    lot[5] = int.Parse(mylottos[mylottos.Count - n].drwtNo6);
                }
                catch
                {
                    MessageBox.Show("회차 번호를 다시확인해주세요1");
                }
            }
        }
 




        private void a()
        {
            try { 
                num = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("구매회차를 입력해주세요");
            }

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            for (int i = 0; i < ar2.Length; i++)
            {
                ar2[i] = r.Next(sum) + 1;
            }

            for (int i = 0; i < ar2.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < ar.Length; j++)
                {
                    sum += ar[j];
                    if (ar2[i] <= sum)
                    {
                        ar2[i] = j + 1;
                        break;
                    }
                }
            }
            sum = 0;
            b();
        }

        private void b()
        {
            int count = 0;
            for (int i = 0; i < ar2.Length; i++)
            {
                for (int j = 0; j < ar2.Length; j++)
                {
                    if (ar2[i] == ar2[j])
                    {
                        count++;
                    }
                }
            }
            if (count == 6) { c(); }
            else { a(); this.sum = 0; }
        }
        private void c()
        {
            Array.Sort(ar2);
            label2.Text = ar2[0].ToString();
            label3.Text = ar2[1].ToString();
            label4.Text = ar2[2].ToString();
            label5.Text = ar2[3].ToString();
            label6.Text = ar2[4].ToString();
            label7.Text = ar2[5].ToString();

            d();
        }
        private void d()
        {
            int[] ar3 = new int[6];
            for(int i = 0; i < ar3.Length; i++)
            {
                ar3[i] = r.Next(1, 45);
                for(int j=0;j < i; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        i--;
                    }
                }
            }
            Array.Sort(ar3);
            //label10.Text = ar3[0].ToString();
            //label11.Text = ar3[1].ToString();
            //label12.Text = ar3[2].ToString();
            //label13.Text = ar3[3].ToString();
            //label14.Text = ar3[4].ToString();
            //label15.Text = ar3[5].ToString();
            int k = r.Next(1, 45);
            for(int i=0; i < ar3.Length; i++)
            {
                if(ar3[i] == k)
                {
                     k = r.Next(1, 45);
                }
            }
            //label16.Text = k.ToString();
            int count = 0;
            List<int> list = new List<int>();
            for(int i = 0; i < ar2.Length; i++)
            {
                for(int j=0; j<ar3.Length-1; j++)
                {
                    if (ar2[i] == ar3[j])
                    {
                        list.Add(ar2[i]);
                        count++;
                    }
                }
            }

           
        }



        private void button2_Click(object sender, EventArgs e)
        {
            a();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { 
                int n = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("회차 번호를 확인해주세요");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            int start = int.Parse(textBox2.Text);
                if (start > 1019)
                {
                    MessageBox.Show("회차번호를 확인해주세요");
                }
                else genLotto(start);
            }
            catch
            {
                MessageBox.Show("회차번호를 확인해주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            int count = 0;
            for (int i = 0; i < ar2.Length; i++)
            {
                for (int j = 0; j < lot.Length; j++)
                {
                    if (ar2[i] == lot[j])
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                textBox1.Text = count.ToString() + "개 맞음";
            }
            else textBox1.Text = "꽝";

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
