using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    public class Worker
    {

        //이런식으로 생성자를 만들 게 되면
        //기존에 암묵적으로 존재했던 아무 것도 생성자가
        //사라진다.
        //그래서 Worker w = new Worker();
        //이런식으로 인스턴스를 만들고 싶으면
        //아무 것도 없는 생성자를 명시해줘야함
        public Worker(string sabeon, string jikgeup, string department, string name, int pay)
        {
            this.sabeon = sabeon;
            this.jikgeup = jikgeup;
            this.department = department;
            this.name = name;
            this.pay = pay;
        }

        //이런식으로 명시를 해줘야 함
        public Worker() { }

        public string sabeon { get; set; }
        public string jikgeup { get; set; }
        public string department { get; set; }
        public string name { get; set; }
        public int pay { get; set; }
    }
}
