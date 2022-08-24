using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Console
{
    public class Lion : Cat
    {
        public int countOfWife { get; set; }

        public void CryOut()
        {
            if(countOfWife==0)
            {
                Console.WriteLine("암사자가 웁니다.");
            }
            else
            {
                Console.WriteLine(countOfWife+"마리의 암사자와 함께 울부 짖습니다.");
            }
        }
    }
}
