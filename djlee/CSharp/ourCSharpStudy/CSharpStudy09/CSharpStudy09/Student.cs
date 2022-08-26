using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    public abstract class Student
    {
        //추상클래스는 기능을 추상화시킴

        //이 것이 역할!!!!!!!!!!!!!!!!!!!!

        //Student를 상속받은 클래스라면
        // 반 드 시!!!!!!!!!
        //이 study를 구체화 해야 함!!!
        public abstract void study();
    }
}
