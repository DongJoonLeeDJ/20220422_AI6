using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{

    //클래스는 하나만 상속시킬 수 있다.
    //인터페이스는 여러 개 상속시킬 수 있다.
    public class SWStudent : Student,IPlay,IFight
    {
       // public int AttackPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AttackPower { get; set; }

        public void Draw()
        {
           // throw new NotImplementedException();
        }

        public void FIght()
        {
            //throw new NotImplementedException();
        }

        public void GamePlay()
        {
            //throw new NotImplementedException();
        }

        public void Lose()
        {
            //throw new NotImplementedException();
        }

        public void PartyPlay()
        {
            //throw new NotImplementedException();
        }

        public override void study()
        {
            Console.WriteLine("컴퓨터 앞에서 공부한다.");
            //throw new NotImplementedException();
        }

        public void Win()
        {
            //throw new NotImplementedException();
        }
    }
}
