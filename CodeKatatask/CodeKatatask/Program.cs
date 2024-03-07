

using System.Security.Cryptography;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
//using namespace std;
//namespace CodeKatatask


//https://github.com/todreami/SpartaCodeKata.git




public class Program
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

    //16번 문제 x만큼 간격이 있는 n개의 숫자, 1월 31일, 수정
    public long[] solutionsixteen(int x, int n)
    {
        long[] answer = new long[n];
        for (int i = 0; i < n; i++)
        {
            answer[i] = (long)x * (i + 1);
        }
        return answer;
    }






    //17번 문제 자연수 뒤집어 배열로 만들기, 수정

    public long[] solutionseventeen(long n)
    {
        int size = n.ToString().Length;
        long[] answer = new long[size];

        for (int i = 0; i < size; i++)
        {
            answer[i] = n % 10;
            n /= 10;
        }
        return answer;
    }


    //18번 문제 문자열을 정수로 바꾸기, 수정

    public int solutioneighteen(string s) 
    {
        int answer = int.Parse(s);
        return answer;
    }



    //19번 문제 정수 제곱근 판별, 수정
    public long solutionnighteen(long n)
    {
        long answer = 0;

        long mul = (long)System.Math.Sqrt(n);

        answer = (mul * mul == n) ? ((mul + 1) * (mul + 1)) : -1;

        return answer;
    }





    //20번 문제 정수 내림차순으로 배치하기, 수정
    public long solutiontwenty(long n)
    {
        long answer = 0;
        char[] a = n.ToString().ToCharArray();
        System.Array.Sort(a);
        System.Array.Reverse(a);
        answer = System.Convert.ToInt64(new string(a));
        return answer;
    }


    //21번 문제 하샤드 수, 오답
    //public bool solutiontwentyone(int x)
    //{
    //    bool answer = true;
    //    int sum = 0;
    //    int n = x;

    //    while (x)
    //    {
    //        sum += x % 10;
    //        x /= 10;
    //    }

    //    if (n % sum == 0)
    //        answer = true;

    //    else
    //        answer = false;

    //    return answer;
    // }

    //22번 문제 두 정수 사이의 합, 오답
    //public long solutiontwentytwo(int a, int b)
    //{
    //    long long answer = 0;
    //    if (a > b)
    //    {
    //        int temp = b;
    //        b = a;
    //        a = temp;
    //    }
    //    for (int i = a; i <= b; i++)
    //    {
    //        answer += i;
    //    }
    //    return answer;
    //}

    //23번 문제 콜라츠 추측 2.13
    public int solutiontwentythree(int num)
    {
        long answer = num;

        for (int i = 0; i < 500; i++)
        {
            if (answer == 1)
                return i;

            answer = (answer % 2 == 0) ? (answer / 2) : (3 * answer + 1);
        }

        return -1;
    }


    //24번 문제 서울에서 김서방 찾기 2.14 오답

    //public string solutiontwentyfour(vector<string> seoul)
    //{
    //    string answer = "";
    //    int nIndex = 0;
    //    for (int i = 0; i < seoul.size(); i++)
    //    {
    //        if (seoul[i] == "Kim")
    //        {
    //            nIndex = i;
    //            break;
    //        }
    //    }

    //    answer = "김서방은 " + to_string(nIndex) + "에 있다";

    //    return answer;
    //}


    //25번 문제 나누어 떨어지는 숫자 2.15 오답

    //public vector<int> solutiontwentyfive(vector<int> arr, int divisor) 2.15
    //{
    //    vector<int> answer;
    //    for (int i = 0; i < arr.size(); i++)
    //    {
    //        if (arr[i] % divisor == 0) answer.push_back(arr[i]);
    //    }
    //    if (!answer.size()) answer.push_back(-1);
    //    sort(answer.begin(), answer.end());
    //    return answer;
    //}

    //26번 문제 음양 더하기 2.16 오답

    //public int solutiontwentysix(int absolutes[], size_t absolutes_len, bool signs[], size_t signs_len)
    //{
    //    int answer = 0;
    //    int sign[] = { 0, };


    //    for (int i = 0; i < absolutes_len; i++)
    //    {
    //        if (signs[i])
    //            answer += absolutes[i];
    //        else
    //            answer -= absolutes[i];
    //    }

    //    return answer;
    //}


    //27번 문제 핸드폰 번호 가리기 2.19 오답

    //  public char* solutiontwentyseven(const char* phone_number) 
    //  {

    //int length = strlen(phone_number);
    //  char* answer = (char*)malloc(length + 1);

    //  strncpy(answer, phone_number, length);

    //  for(int i=0;i<length-4;i++)
    //  {
    //      answer[i]='*';
    //  }
    //  answer[length] = NULL;
    //  return answer;

    // }


    //28번 문제 없는 숫자 더하기 2.20 오답
    //public int solutiontwentyeight(int numbers[], size_t numbers_len)
    //{
    //    int answer = 45;

    //    for (int i = 0; i < numbers_len; i++)
    //    {
    //        answer -= numbers[i];
    //    }

    //    return answer;
    //}

    //29번 제일 작은 수 제거하기 2.21 오답
    //public vector<int> solutiontwentynine(vector<int> arr)
    //{
    //    vector<int> answer = arr;

    //    int nMin = *min_element(arr.begin(), arr.end());
    //    int pos = find(answer.begin(), answer.end(), nMin) - answer.begin();
    //    answer.erase(answer.begin() + pos);

    //    return answer.empty() ? vector<int>(1, -1) : answer;
    //}


    //30번 가운데 글자 가져오기 2.22 오답
    //public char* solutionthirty(const char* s) 
    //    {
    //        char* answer;
    //    int c = strlen(s);
    //    if(c % 2)
    //    {
    //        answer = (char*)malloc(2);
    //        answer[0] = s[c/2];
    //        answer[1] = '\0';
    //    }
    //    else
    //    {
    //        answer = (char*)malloc(3);
    //        answer[0] = s[c/2-1];
    //        answer[1] = s[c/2];
    //        answer[2] = '\0';
    //    }
    //    return answer;
    //}

    //31번 수박수박수박수박수박수? 2.23 오답
    //public char* solutionthirtyone(int n)
    //{
    //    char* add1 = "수";
    //    char* add2 = "박";
    //    int len = strlen(add1);
    //    char* answer = (char*)malloc(n * len);
    //    for (int i = 0; i < n; i++)
    //    {
    //        strcpy(&answer[i * len], i % 2 == 0 ? add1 : add2);
    //    }

    //    return answer;
    //}

    //32번 내적 2.26 오답
    //public int solutionthirtytwo(int a[], size_t a_len, int b[], size_t b_len)
    //{
    //    int answer = 0;
    //    int i;

    //    for (i = 0; i < a_len; i++)
    //        answer += a[i] * b[i];

    //    return answer;
    //}

    //33번 약수의 개수와 덧셈 2.27 오답
    //public int solutionthirtythree(int left, int right)
    //{
    //    int answer = 0;
    //    int count = 0;

    //    for (int i = left; i <= right; i++)
    //    {
    //        for (int j = 1; j <= i; j++)
    //        {
    //            if (i % j == 0)
    //            {
    //                count++;
    //            }

    //        }

    //        answer += (count & 1) ? -i : i;
    //        count = 0;
    //    }


    //    return answer;
    //}

    //34번 문자열 내림차순으로 배치하기 2.28
    public string solutionthirtyfour(string s)
    {
        string answer = "";
        char[] chr_temp = s.ToCharArray();

        answer = new string(s.OrderByDescending(x => x).ToArray());
        return answer;
    }

    //35번 문자열 내림차순으로 배치하기 2.28
    public long solutionthirtyfive(int price, int money, int count)
    {
        long answer = 0;
        long total = 0;


        for (int i = 1; i < count + 1; i++)
        {
            total += price * i;
        }

        if (money < total)
            answer = total - money;

        else
            answer = 0;

        return answer;
    }

    //36번 문자열 다루기 기본
    public bool solutionthirtysix(string s)
    {
        bool answer = false;

        if (s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s, out int temp);
        }

        return answer;
    }

    //37번 문자열 다루기 기본
    public int[,] solutionthirtyseven(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }

    //38번 직사각형 별찍기
    public static void Mainthirtyeight()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    //39번 최대공약수와 최소공배수
    public int[] solutionthirtnine(int n, int m)
    {
        int[] answer = new int[2];
        int min;
        int max;

        min = gcd(n, m);
        max = (n * m) / min;

        answer[0] = min;
        answer[1] = max;
        return answer;
    }

    public int gcd(int n, int m)
    {
        if (m == 0) return n;
        else return gcd(m, n % m);
    }






}













































