using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = 
                new List<Animal>();

            animals.Add(new Animal());
            animals.Add(new Animal());

            Dog d1 = new Dog();
            Dog d2 = new Dog();
            animals.Add(d1);
            animals.Add(d2);

            //다형성 활용
            Animal c1 = new Cat();
            Animal c2 = new Cat();
            animals.Add(c1);
            animals.Add(c2);

            animals.Add(new Hamster());
            animals.Add(new Hamster());

            Animal l1 = new Lion(); 
            Cat l2 = new Lion(); //Lion은 Cat의 자손 클래스이다.
            (l1 as Lion).countOfWife = 1; //형변환
            //l2는 암사자라서 countOfWife값이 0
            //정수 값 지정 안하면 기본 값 0임(=자바도 똑같음)

            animals.Add(l1);
            animals.Add(l2);


            Tiger t1 = new Tiger();

            t1.Name = "랑이";
            t1.Age = 5;
            t1.pattern = "호피";

            Animal t2 = new Tiger();
            if (t2 is Tiger) //형변환 가능여부 체크
            {
                (t2 as Tiger).Name = "호랭";
                (t2 as Tiger).Age = 2;
                (t2 as Tiger).pattern = "민";
            }

            animals.Add(t1);
            animals.Add(t2);

            foreach (var item in animals)
            {
                item.Sleep();
                if (item is Dog)
                    ((Dog)(item)).Bark();
                if (item is Cat)
                    (item as Cat).meow(); //Lion, Tiger도 meow호출함... 
                //즉 이 클래스들은 Cat으로부터 왔기 때문이다.
                //Dog, Cat, Hamster들이 Sleep을 호출 할 수 있는 것과 같다.


                //item 역시 var 였으나 Lion으로 형변환
                //형변환 성공했다면 l은 Lion타입이 맞고(new Lion으로 인스턴스 만들어짐)
                //형변환 실패했다면 l 에는 null값이 있다.(Lion이외의 타입인 경우)
                var l = item as Lion;
                if(l!=null) //l이 Lion으로 인스턴스 만들었다면 null이 아니다.
                    l.CryOut();

                if(item is Tiger)
                {
                    var t = item as Tiger;
                    t.Fight();
                }

            }






        }
    }
}
