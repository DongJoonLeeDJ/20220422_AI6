using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto645_Tp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //1. 난수 생성을 위한 랜덤 클래스 만들기
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //using System.Threading; 기능 추가 요망
            //GetNum 함수 사용, 무명 함수 실행
            //t*.start로 실행
            Thread t1 = new Thread(() => GetNum(textBox1)); t1.Start();
            Thread t2 = new Thread(() => GetNum(textBox2)); t2.Start();
            Thread t3 = new Thread(() => GetNum(textBox3)); t3.Start();
            Thread t4 = new Thread(() => GetNum(textBox4)); t4.Start();
            Thread t5 = new Thread(() => GetNum(textBox5)); t5.Start();
            Thread t6 = new Thread(() => GetNum(textBox6)); t6.Start();
            Thread t7 = new Thread(() => GetNum(textBox7)); t7.Start();
        }
        //GetNum 메소드 실행, 만들기
        private void GetNum(TextBox t)
        {
            //1 이상 46 미만, 정수를 받아와서 난수 생성
            int n = r.Next(1, 46);
            SetTextBox(t, n);
        }
        //STB 메소드 만들기, 2개의 인자
        //델리게이트 선언, 2개의 인자
        //어떤 쓰레드가 STB를 호출, UI 쓰레드가 아니기 때문에 인보크리콰이어드
        //델리게이트 통해서 다시 STB 호출, UI 쓰레드가 델리게이트 메소드 호출
        public delegate void SetTextBoxDelegate(TextBox t, int n);
        public void SetTextBox(TextBox t, int n)
        {
            //TB는 소유자가 UI(?) Thread?? UI T가 오너??
            //InvokeRequired를 사용하는 이유
            if (t.InvokeRequired)
            {
                //델리게이트(대리자) 만들기
                SetTextBoxDelegate d = new SetTextBoxDelegate(SetTextBox);
                //인보크 시켜줌, 2개의 인자, STB 메소드 호출

                //메인 쓰레드가 대리자한테 대리자가 가지고 있는 메소드를
                //수행하도록 떠넘김
                this.Invoke(d, new object[] { t, n });
            }
            else
            {
                //소수를 반환했다, 엘스에 들어왔다는 것은, 
                //컨트롤에 직접 접근해도 문제가 없다는 것
                //UI 쓰레드가 델리게이트를 통해서 STB를 호출하는 경우에,
                //else로 들어오는 것
                //STB의 코딩을 마침
                t.Text=n.ToString();   
                //우리가 만든 위의 워크쓰레드는 직접 글을 쓸 수 없음
                //고로 STB가 UI쓰레드인지 아닌지 알아야 함
                //고로 인보크 리콰이어드를 물어봄!
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
