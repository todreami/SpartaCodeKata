﻿

using System.Security.Cryptography;

namespace CodeKatatask
{
    internal class Program
    {
        // 8번문제 각도기
        static void Main(string[] args)
        {

            static int solution(int angle)
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
        }
    }
}














