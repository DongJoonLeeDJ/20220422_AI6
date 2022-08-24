using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Winform
{
    public class Tiger : Cat
    {
        public string pattern { get; set; }

        public void Fight()
        {
            Console.WriteLine("내 이름은 " + Name);
            Console.WriteLine(Age+"년 인생 최후의 싸움을 시작한다.");
            Console.WriteLine(pattern+"무늬 호랑이들에게 영광을 캬오오");
        }
    }
}
