

using System.Security.Cryptography;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
//using namespace std;
//namespace CodeKatatask







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



    //10번문제 배열의 평균값
    public double solutionten(int[] numbers)
            {

                return numbers.Average();

            }





        //11번문제 짝수와 홀수
        public string solutioneleven(int num)
        {
            return (num % 2 == 0) ? "Even" : "Odd";
        }



        //12번문제 평균 구하기
        public double solutiontwelve(int[] arr)
        {
            double answer = 0;
            answer = arr.Average();
            return answer;
        }


        //13번 문제 자릿수 더하기
        public int solutionthirteen(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n /= 10;
            }
            return answer;
        }

        //14번 문제 약수의 합
        public int solutionfourteen(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                {
                    answer += i;
                }
            }
            return answer;

        }
        //15번 문제 나머지가 1이 되는 수 찾기
        public int solutionfifteen(int n)
        {
            int answer = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }

            }
            return answer;

        }

    //16번 문제 x만큼 간격이 있는 n개의 숫자, 1월 31일, 오답
    // public int solutionsixteen(int n)
    //{
    //vector<long long> solution(int x, int n)
    //{
    //    vector < long long> answer;
    //    for (int i = 0; i < n; i++)
    //        answer.push_back(x * (i + 1));
    //    return answer;
    //}



    //17번 문제 자연수 뒤집어 배열로 만들기

    //   public int* seventeensolution(long long n)
    //{
    //    int count = 0;
    //    long long Num = n;

    //    while (true)
    //    {
    //        count++;
    //        Num = Num / 10;

    //        if (Num == 0) break;
    //    }

    //    Num = n;
    //    int* answer = (int*)malloc(sizeof(int) * count);

    //    for (int i = 0; i < count; i++)
    //    {
    //        answer[i] = Num % 10;
    //        Num = Num / 10;
    //    }

    //    return answer;
    //}


    //18번 문제 문자열을 정수로 바꾸기

    //public int solutioneighteen(const char* s) 
    //{
    //       int answer = atoi(s);
    //return answer;
    //}




}











































