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

        //생성자
        //이 생성자를 안 적으면 public Cat() {} 이거처럼
        //아무 것도 없는 생성자가 암묵적으로 만들어져 있는 것!
        public Cat()
        {

        }

        //생성자도 오버로딩이 된다
        //메소드처럼 매개변수에 따라서 여러 개의 생성자
        //만들 수 있다.
        public Cat(int age)
        {
            this.age = age;
        }
        public Cat(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        public void meow()
        {
            System.Windows.Forms.MessageBox.Show
                (name+"가 야옹한다.");
        }

        //return 값이 string
        //여기에서 만든 값이 이 메소드를 호출한 곳으로
        //대입이 된다.
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

        //매개변수가 없는 meow를 오버로딩한 메소드
        //오버로딩 : 리턴타입은 관계없고
        //매개변수가 다르면 메소드 이름이 같아도
        //다른 메소드로 간주한다.
        public void meow(int count)
        {
            System.Windows.Forms.MessageBox.Show
                (color+"색 고양이가" +count+"번 야옹");
        }

    }
}
