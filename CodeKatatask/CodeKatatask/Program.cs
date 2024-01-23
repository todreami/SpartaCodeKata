

using System.Security.Cryptography;
using System.Linq;

namespace CodeKatatask
{
    internal class Program
    {







        // 8번문제 각도기
        static void Main(string[] args)
        {

            static int solutioneight(int angle)
            {
                int answer = 0;

                if (0 < angle && angle < 90)
                {
                    answer = 1;
                }
                if (angle == 90)
                {
                    answer = 2;
                }
                if (90 < angle && angle < 180)
                {
                    answer = 3;
                }
                if (angle == 180)
                {
                    answer = 4;
                }
                return answer;
            }

            // 9번문제 짝수의 합
            static int solutionnine(int n)
            {
                int answer = 0;

                for (int i = 2; i <= n; i += 2)
                {
                    answer += i;
                }

                return answer;
            }
        }



        //10번문제 배열의 평균값
            public double solutioneighth(int[] numbers)
            {

                return numbers.Average();

            }





        //11번문제







    }





}














