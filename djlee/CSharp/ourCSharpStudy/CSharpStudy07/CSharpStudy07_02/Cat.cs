using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07_02
{
    public class Cat
    {
        public string name { get; set; }
        public int age { get; set; }  
        public string color { get; set; }

        public void meow()
        {
            System.Windows.Forms.MessageBox.Show
                (name+"가 야옹한다.");
        }
        public string eat()
        {
            return name + "야옹이가 " + age + "살에 걸맞게 먹는다.";
        }
        //클래스 메소드
        //인스턴스 별로 다르게 동작하는 것이 아니라
        //한 클래스가 모두 공유하는 메소드(클래스 변수랑 마찬가지로
        //static 키워드가 있어야 한다.)
        public static void jump()
        {
            System.Windows.Forms.MessageBox.Show("고양이 점프!!!");
        }

    }
}
