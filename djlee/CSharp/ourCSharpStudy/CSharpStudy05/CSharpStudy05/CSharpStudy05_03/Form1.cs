using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharpStudy05_03
{
    public partial class Form1 : Form
    {
        List<Weather> w = new List<Weather>();


        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xe = XElement.Load(url);
            foreach(var item in xe.Descendants("data"))
            {
                Weather t = new Weather();
                t.Name = item.Element("wfKor").Value;
                t.Temp = double.Parse(item.Element("temp").Value);
                w.Add(t);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = w;
        }
    }
}
