

using System.Security.Cryptography;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System;
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

    //40번 3진법 뒤집기
    public int solutionforty(int n)
    {
        int answer = 0;
        while (n > 0)
        {
            answer *= 3;
            answer += n % 3;
            n /= 3;
        }
        return answer;
    }
    //41번 이상한 문자 만들기
    public string solutionfortyone(string s)
    {
        string answer = "";
        int wordIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += s[i];
                wordIndex = 0;
                continue;
            }
            if (wordIndex % 2 == 0)
            {
                answer += s[i].ToString().ToUpper();
                wordIndex++;
            }
            else
            {
                answer += s[i].ToString().ToLower();
                wordIndex++;
            }
        }
        return answer;
    }

    //42번 삼총사
    public int solutionfortytwo(int[] number)
    {
        int cnt = 0;
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++)
            {
                for (int k = j + 1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        cnt++;
                    }
                }
            }
        }
        return cnt;
    }

    //43번 크기가 작은 부분문자열

    public int solutionfortythree(string t, string p)
    {
        int answer = 0;
        long num = 0;
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            num = long.Parse(t.Substring(i, p.Length));
            if (num <= long.Parse(p)) { answer++; }
        }
        return answer;
    }

    //44번 최소직사각형
    public int solutionfortyfour(int[,] sizes)
    {
        int max1 = 0;
        int max2 = 0;
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            max1 = Math.Max(max1, Math.Max(sizes[i, 0], sizes[i, 1]));
            max2 = Math.Max(max2, Math.Min(sizes[i, 0], sizes[i, 1]));
        }

        int answer = max1 * max2;
        return answer;
    }

    //45번 시저 암호
    public string solutionfortyfive(string s, int n)
    {
        string answer = "";

        char[] temp = s.ToCharArray();

        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == ' ')
            {
                answer += temp[i].ToString();
                continue;
            }
            for (int j = 1; j <= n; j++)
            {
                if (temp[i] == 'Z')
                    temp[i] = 'A';
                else if (temp[i] == 'z')
                    temp[i] = 'a';
                else
                    temp[i] = (char)(temp[i] + 1);
            }
            answer += temp[i].ToString();
        }
        return answer;
    }

    //46번 숫자 문자열과 영단어
    public int solutionfortysix(string s)
    {
        int answer = 0;

        s = s.Replace("zero", "0");
        s = s.Replace("one", "1");
        s = s.Replace("two", "2");
        s = s.Replace("three", "3");
        s = s.Replace("four", "4");
        s = s.Replace("five", "5");
        s = s.Replace("six", "6");
        s = s.Replace("seven", "7");
        s = s.Replace("eight", "8");
        s = s.Replace("nine", "9");

        int t;
        bool strToInt = int.TryParse(s, out t);
        if (strToInt) answer = t;

        return answer;
    }


    //47번 문자열 내 마음대로 정렬하기
    public string[] solutionfortyseven(string[] strings, int n)
    {
        string[] answer = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();

        return answer;
    }

    //48번 K번째수
    public int[] solutionfortyeight(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int index = 0; index < answer.Length; index++)
        {
            int i = commands[index, 0];
            int j = commands[index, 1];
            int k = commands[index, 2];

            int[] temp = new int[j - i + 1];

            int idx = 0;

            for (int arrayIndex = i - 1; arrayIndex < j; arrayIndex++)
            {
                temp[idx++] = array[arrayIndex];
            }

            Array.Sort(temp);

            answer[index] = temp[k - 1];
        }

        return answer;
    }

    //49번 두 개 뽑아서 더하기
    public int[] solutionfortynine(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> empty = new List<int>();
        List<int> answers = new List<int>();
        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                empty.Add(numbers[i] + numbers[j]);
            }
        }
        for (int i = 0; i < empty.Count; i++)
        {
            if (!answers.Contains(empty[i]))
                answers.Add(empty[i]);
        }
        answers.Sort();
        return answers.ToArray();
    }

    //50번 가장 가까운 같은 글자
    public int[] solutionfifty(string s)
    {
        int[] answer = new int[s.Length];
        Dictionary<char, int> values = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (values.ContainsKey(currentChar))
            {
                int index = values[currentChar];
                answer[i] = i - index;
            }
            else
            {
                answer[i] = -1;
            }
            values[currentChar] = i;
        }
        return answer;
    }


    //51번 푸드 파이트 대회
    public string solutionfiftyone(int[] food)
    {
        string answer = "";
        string str = "";

        for (int i = 1; i < food.Length; i++)
        {
            for (int j = 0; j < food[i] / 2; j++)
            {
                answer += i.ToString();
            }
        }
        str = String.Concat(answer.Reverse());
        answer += "0" + str;
        return answer;
    }

    //52번 콜라
    public int solutionfiftytwo(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            answer += (n / a) * b;
            n = (n / a) * b + n % a;
        }
        return answer;
    }

    //53번 명예의 전당
    public int[] solutionfiftythree(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        List<int> board = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            if (board.Count == k)
            {
                if (board[0] > score[i])
                {
                    answer[i] = board[0];
                    continue;
                }
                board.RemoveAt(0);
            }
            board.Add(score[i]);
            board.Sort();
            answer[i] = board[0];
        }
        return answer;
    }

    //54번 2016년
    public string solutionfiftyfour(int a, int b)
    {
        string answer = "";
        string[] dayName = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU", };
        int days = 0;

        for (int i = 1; i < a; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                days += 31;
            else if (i == 2)
                days += 29;
            else
                days += 30;
        }
        days += b - 1;
        answer = dayName[days % 7];
        return answer;
    }

    //55번 카드뭉치
    public string solutionfiftyfive(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = "Yes";

        int idx1 = 0;
        int idx2 = 0;
        for (int i = 0; i < goal.Length; i++)
        {
            if (idx1 < cards1.Length && goal[i] == cards1[idx1])
            {
                idx1++;
                continue;
            }
            else if (idx2 < cards2.Length && goal[i] == cards2[idx2])
            {
                idx2++;
                continue;
            }
            else
            {
                answer = "No";
            }
        }
        return answer;
    }

    //56번 과일 장수

    public int solutionfiftysix(int k, int m, int[] score)
    {
        int answer = 0;
        int index = m - 1;
        Array.Sort(score);
        Array.Reverse(score);

        for (int i = 0; i < score.Length / m; i++)
        {
            answer += score[index] * m;
            index += m;
        }
        return answer;
    }

    //57번 모의고사완전탐색
    public int[] solutionfiftyseven(int[] answers)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(1, 0);
        dic.Add(2, 0);
        dic.Add(3, 0);

        int[] one = new int[] { 1, 2, 3, 4, 5 };
        int[] two = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] three = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int loop = 0;
        int oneIndex = 0;
        int twoIndex = 0;
        int threeIndex = 0;
        int max = 0;
        while (loop < answers.Length)
        {
            if (loop % one.Length == 0)
            {
                oneIndex = 0;
            }
            if (loop % two.Length == 0)
            {
                twoIndex = 0;
            }
            if (loop % three.Length == 0)
            {
                threeIndex = 0;
            }

            if (one[oneIndex] == answers[loop])
            {
                dic[1] += 1;
                max = dic[1] > max ? dic[1] : max;
            }
            if (two[twoIndex] == answers[loop])
            {
                dic[2] += 1;
                max = dic[2] > max ? dic[2] : max;
            }
            if (three[threeIndex] == answers[loop])
            {
                dic[3] += 1;
                max = dic[3] > max ? dic[3] : max;
            }

            oneIndex++;
            twoIndex++;
            threeIndex++;
            loop++;
        }
        List<int> list = new List<int>();

        foreach (var endDic in dic)
        {
            if (max == endDic.Value)
            {
                list.Add(endDic.Key);
            }
        }
        return list.ToArray();
    }



    //58번 소수 만들기
    public int solutionfiftyeight(int[] nums)
    {
        int answer = 0;


        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {

                    int n = nums[i] + nums[j] + nums[k];

                    int count = 0;
                    for (int t = 2; t <= n; t++)
                    {
                        if (n % t == 0) count++;
                    }

                    if (count == 1) answer++;
                }
            }
        }
        return answer;
    }


    //59번 덧칠하기

    public int solutionfiftynine(int n, int m, int[] section)
    {
        int answer = 0;

        int num = 0;
        for (int i = 0; i < section.Length; i++)
        {

            if (section[i] > num)
            {
                num = (section[i] + m) - 1;
                answer++;
            }
        }

        return answer;
    }

    //60번 기사단원의 무기
    public int solutionsixty(int number, int limit, int power)
    {
        int answer = 0;
        int[] cnt = new int[number + 1];
        for (int i = 1; i <= number; i++)
        {
            for (int j = i; j <= number; j += i)
            {
                cnt[j]++;
            }
        }

        for (int i = 1; i <= number; i++)
        {
            if (cnt[i] > limit)
                answer += power;
            else
                answer += cnt[i];
        }

        return answer;
    }


    //61번 로또의 최고 순위와 최저 순위
    public int[] solutionsixtyone(int[] lottos, int[] win_nums)
    {
        int right = 0;
        int zeroCount = 0;
        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeroCount++;
            }
            if (lottos.Contains(win_nums[i]))
            {
                right++;
            }
        }
        int MaxCollect = zeroCount + right;
        int MinCollect = right;
        if (MinCollect == 0) MinCollect++;
        if (MaxCollect == 0) MaxCollect++;
        int[] answer = new int[] { 7 - MaxCollect, 7 - MinCollect };
        return answer;
    }

    //62번 옹알이 (2)
    public int solutionsixtytwo(string[] babbling)
    {
        int answer = 0;
        string[] talk = new string[] { "aya", "ye", "woo", "ma" };

        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < talk.Length; j++)
            {
                string str = talk[j] + talk[j];
                babbling[i] = babbling[i].Replace(str, "@").Replace(talk[j], " ");
            }
            if (babbling[i].Trim().Length < 1)
                answer++;
        }

        return answer;
    }
}













































