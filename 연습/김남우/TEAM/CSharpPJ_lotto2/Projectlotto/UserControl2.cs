using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectlotto
{
    public partial class game : UserControl
    {
        int[] lottoN = new int[7];
        public CircularLabel[] labels = new CircularLabel[35];
        Random r = new Random();

        public game()
        {
            InitializeComponent();
            labels[0] = gb11;            labels[1] = gb12;            labels[2] = gb13;            labels[3] = gb14;            labels[4] = gb15;
            labels[5] = gb16;            labels[6] = gb17;            
            labels[7] = gb21;            labels[8] = gb22;            labels[9] = gb23;            labels[10] = gb24;            labels[11] = gb25;
            labels[12] = gb26;            labels[13] = gb27;          
            labels[14] = gb31;            labels[15] = gb32;            labels[16] = gb33;            labels[17] = gb34;
            labels[18] = gb35;            labels[19] = gb36;            labels[20] = gb37;            
            labels[21] = gb41;            labels[22] = gb42;            labels[23] = gb43;            labels[24] = gb44;
            labels[25] = gb45;            labels[26] = gb46;            labels[27] = gb47;
            labels[28] = gb51;            labels[29] = gb52;            labels[30] = gb53;            labels[31] = gb54;            labels[32] = gb55;
            labels[33] = gb56;            labels[34] = gb57;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = null;
                labels[i].BackColor = Color.White;
                labels[i].ForeColor = Color.White;
              

            }

        }
        private void unduplication()
        {
            for (int i = 0; i < lottoN.Length; i++)
            {
                lottoN[i] = r.Next(1, 46);

                for (int j = 0; j < i; j++)
                {
                    if (lottoN[i] == lottoN[j])
                    {
                        i--;
                    }
                } // Console.WriteLine(arr[i]);
            }
            int nTemp;
            //int nCount = 0;

            for (int i = 0; i < lottoN.Length - 2; i++)
            {
                for (int j = 0; j < lottoN.Length - 2; j++)
                {
                    if (lottoN[j] > lottoN[j + 1])
                    {
                        nTemp = lottoN[j + 1];
                        lottoN[j + 1] = lottoN[j];
                        lottoN[j] = nTemp;
                    }
                }
            }



        }
        private void color(CircularLabel l)
        {
            //Color c = new Color();
            
            int num = int.Parse(l.Text);
            if (num <= 10)
                //l.BackColor = Color.Gold;
                l.BackColor = ColorTranslator.FromHtml("#fbc400");
            else if (num > 10 && num <= 20)
            {
                //l.BackColor = Color.DodgerBlue;
                l.BackColor = ColorTranslator.FromHtml("#68c7f1");
            }
            else if (num > 20 && num <= 30)
            {
                //l.BackColor = Color.DarkOrange;
                l.BackColor = ColorTranslator.FromHtml("#ff7171");
            }
            else if (num > 30 && num <= 40)
            {
                //l.BackColor = Color.DimGray;
                l.BackColor = ColorTranslator.FromHtml("#aaaaaa");
            }
            else if (num > 40 && num <= 45)
            {
                //l.BackColor = Color.ForestGreen;
                l.BackColor = ColorTranslator.FromHtml("#add53f");
            }


        }

        private void one_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            gb17.Text = lottoN[6].ToString();

            for (int i = 0; i < 7; i++)
                color(labels[i]);
        }

        private void two_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            gb17.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();
            for (int i = 0; i < 14; i++)
                color(labels[i]);
        }

        private void three_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            gb17.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();
            for (int i = 0; i < 21; i++)
                color(labels[i]);
        }

        private void four_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            gb17.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();

            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();
            gb47.Text = lottoN[6].ToString();
            for (int i = 0; i < 28; i++)
                color(labels[i]);
        }

        private void five_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            gb17.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();

            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();
            gb47.Text = lottoN[6].ToString();

            unduplication();

            gb51.Text = lottoN[0].ToString();
            gb52.Text = lottoN[1].ToString();
            gb53.Text = lottoN[2].ToString();
            gb54.Text = lottoN[3].ToString();
            gb55.Text = lottoN[4].ToString();
            gb56.Text = lottoN[5].ToString();
            gb57.Text = lottoN[6].ToString();

            for (int i = 0; i < 35; i++)
                color(labels[i]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = null;
                labels[i].BackColor = Color.White;
            }
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
}
