using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    public class Student
    {
        public string hakbeon { get; set; }
        public string name { get; set; }
        public int age { get; set; }


        //{get; set;}
        //java의 Getter, Setter랑 똑같음

        //get; set; 유래
        //그냥 public을 쓸 경우, 
        //휴먼 오류가 났을 때 예외처리 할 수 없다.
        //그리고 외부 클래스에서 이 부분은 안 건드렸으면 할 때...
        //그 때는 private을 적거나 아무 것도 적지 않는다.

        //public int score;
        private int score;//참고로 앞에 아무 것도 안 적으면 기본값은 private

        //java 스타일 Getter Setter
        public int getScore()
        {
            return score;
        }

        //참고 this.score는 멤버변수
        //그냥 score는 매개변수(괄호 안에 있는 것)
        public void setScore(int score)
        {
            if (score <= 0)
                this.score = 0;
            else
                this.score = score;
        }

        //getter, setter를 축약1

        public int Score1 { get { return score; }  
            set { 
                if(value<=0)
                {
                    score = 0;
                }
                else
                {
                    score = value; } }

                }

        //getter, setter를 축약2
        public int Score2 { get => score; set => score = value; }

        //위의 getter,setter나 축약1은 예외처리 추가 가능

        //축약2를 더 축약한 형태
        //private 변수, public 변수 이렇게 2개 두지 말고
        //그냥 public 하나만 두자
        //자바의 Getter, Setter가 관례화되가지고, 그 안에 예외처리 안 넣는거랑
        //똑같다.
        public int Score { get; set; }


        //그러면 그냥 get;set;도 생략하면 안 될까?
        //추후 datagridview에 datasource 추가할 때, get;set; 붙어있는것만 반영됨


    }
}
