using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{

    //특정 기능, 속성을 반드시 구현해야 한다고 명시
    //추상클래스랑 차이점
    //인터페이스는 여러 개를 붙일 수 있다.(콤마로)
    //클래스는 여러개 붙일 수 없다.
    public interface IFight
    {
        int AttackPower { get; set; }
        void FIght();
        void Draw();
        void Win();
        void Lose();
    }
}
