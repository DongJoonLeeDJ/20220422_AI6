using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudy07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = textBox1.Text;
            //숫자 아니어도 됨
            //대신 숫자 아닌 값 입력시 age에는 0이 들어감)
            int.TryParse(textBox2.Text, out int age);
            c.age = age;

            c.meow();
            string message = c.eat();
            MessageBox.Show(message);

            Cat.jump();

            Cat c2 = new Cat();
            c2.name = textBox3.Text;
            try
            {
                //무조건 숫자 넣어야 함(Parse)
                c2.age = int.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                c2.age = 0;
            }

            c2.meow();
            MessageBox.Show(c2.eat());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c1 = new Cat();
            c1.color = "red";
            c1.name = "이동준";
            c1.age = 34;
            c1.meow();
            c1.meow(5);
        }
    }
}
