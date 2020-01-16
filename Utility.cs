using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public void leap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap yaer");
            }
        }

        //program for flipcoin
        public void flip()
        {
            Random rand = new Random();
            if (rand.NextDouble() < 0.5)
            {
                Console.WriteLine("heads");
            }
            else
            {
                Console.WriteLine("tails");
            }
        }

        //PowerOf2 program
        public void powerOf2(int n)
        {
            int i = 1;
            int res = 1;
            while (i <= n)
            {
                res = res * 2;
                i++;
                Console.WriteLine(res);
            }
        }

        //harmonic number program
        public double harmonicValue(double n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (double)1 / i;
            }
            return sum;
        }

        //prime factorization program
        public void primeFactor(int n)
        {
            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n = n / 2;
            }
            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }
            if (n > 1)
                Console.WriteLine(n);
        }

        //program for gambler
        public void gambler(int stake, int goal, int trails)
        {
            int bets = 0;
            int wins = 0;
            for (int i = 0; i < trails; i++)
            {
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    Random rand = new Random();
                    bets++;
                    if (rand.NextDouble() < 0.5)
                        cash++;
                    else
                        cash--;
                }
                if (cash == goal)
                    wins++;
            }
            Console.WriteLine(wins + "  " + "wins of" + trails);
            Console.WriteLine("percentage of wins" + " " + 100 * wins / trails);
            Console.WriteLine("average of bets" + " " + 1.0 * bets / trails);
        }

        //coupon code
        public void couponcode()
        {
            char[] ch = "abcdefghijklmnopq".ToCharArray();
            int max = 100000000;
            Random r = new Random();
            double d = r.NextDouble();
            int random = (int)(d * max);
            String s = "";
            Console.WriteLine("random double" + " " + d + " " + "random at start" + " " + random);
            while (random > 0)
            {
                s = s + (ch[random % ch.Length]);
                random /= ch.Length;
                Console.WriteLine("random" + " " + random % ch.Length + " " + s);
            }
            String couponcode = s.ToString();
            Console.WriteLine("coupon code" + " " + couponcode);
        }

        //sum of three numbers adds to zero
        public void sumOfThree(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k] + " ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

        //Distance
        public double distance(double x, double y)
        {
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            double distance = Math.Sqrt(x + y);
            return distance;
        }

        //permutation of strings
        public void stringPermutation(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    string s1 = str;
                    Console.WriteLine(swap(s1, i, j));
                }
            }
        }
        public String swap(string s, int i, int j)
        {
            char temp;
            char[] ch = s.ToCharArray();
            temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
            string a = new string(ch);
            return a;
        }

        //Quadratic program
        public void quadratic(double a, double b, double c)
        {
            //ax2+bx+c
            double root1, root2;
            double delta = b * b - 4 * a * c;
            Console.WriteLine("delta {0}", delta);
            if (delta > 0)
            {
                root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("delta is greater than 0" + " " + root1 + " " + root2);
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("delta is equal to 0" + " " + root1 + " " + root2);
            }
            else
            {
                double real = -b / (2 * a);
                double imaginary = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("real and imaginary part of equ" + " " + real + " " + imaginary);
            }
        }

        //program for windchill
        public double windchill(double t, double v)
        {
            double w = 35.74 + 0.6215 + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            return w;
        }

        //replacing template by user input
        public void replaceName(String temp)
        {
            string name = Console.ReadLine();
            if (name.Length > 3)
            {
                temp = temp.Replace("<<username>>", name);
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("user name should be more than 3 letters");
                replaceName(temp);
            }
        }

        // temperature conversion
        public double tempCelToFah(double celcius)
        {
            double fah = (celcius * 9.5) + 32;
            return fah;
        }
        public double tempFahToCel(double fah)
        {
            double cel = (fah - 32) * 5 / 9;
            return cel;
        }

        //monthly payment
        public double monthlyPayment(double P, double y, double R)
        {
            double n = 12 * y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));
            return payment;
        }

        //sqrt using newtons method
        public double sqrt(double c)
        {
            if (c < 0)
                return Double.NaN;
            double t = c;
            double epsilon = 1E-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }

        //binary number
        public string binary(int n)
        {
            if (n == 0)
                return "0";
            else
            {
                string binary = "";
                while (n > 0)
                {
                    int rem = n % 2;
                    binary = rem + binary;
                    n /= 2;
                }
                return binary;
            }
        }
        //binaryswap
        public void binaryswap(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            String binary = "";
            while (n > 0)
            {
                int rem = n % 2;
                binary = rem + binary;
                n = n / 2;
            }
            Console.WriteLine(binary);
            string s = binary;
            if (s.Length > 4)
            {
                string s1 = s.Substring(0, s.Length / 2);
                string s2 = s.Substring(4, s.Length - 1);
                string s3 = s2 + s1;
                Console.WriteLine(s3);
            }
            else
                Console.WriteLine("no swapping");
        }

        public int guess()
        {
            int low = 0, high = 127, mid;
            while (low < high)
            {
                mid = (low + high) / 2;
                Console.WriteLine("enter 1 if number is blw " + low + " " + mid + " " + "enter 2 if number is blw " + (mid + 1) + " " + high);
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                    high = mid;
                else
                    low = mid + 1;
            }
            return low;
        }

        //vending machine
        static int I, TOTAL;
        static int[] NOTES = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void notes(int value)
        {
            if (value / NOTES[I] != 0)
            {
                TOTAL += (value / NOTES[I]);
                Console.WriteLine(NOTES[I] + "rs notes" + value / NOTES[I]);
                value = value % NOTES[I];
            }
            I++;
            if (value == 0)
            {
                Console.WriteLine("total notes" + TOTAL);
                return;
            }
            notes(value);
        }

        //stop watch
        static double start = 0, stop = 0;
        public void startTime()
        {
            start = Environment.TickCount;
            Console.WriteLine("started at" + " " + start);
        }
        public void stopTimer()
        {
            stop = Environment.TickCount;
            Console.WriteLine("stopped at" + " " + stop);
        }
        public void elapsedTime()
        {
            Console.WriteLine("elapsed time" + (stop - start) / 1000);
        }

        //tiktoctoe 
        static int player = 0;
        static double[,] board = new double[3, 3];
        static bool isEmpty = true;
        public void initBoard()
        {
            Console.WriteLine("game starts");
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = -10;
                }
            }
            Console.WriteLine("board is");
            display();
        }
        public void display()
        {
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine("--------------");
                Console.WriteLine("||");
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        count++;
                        Console.WriteLine("o |");
                    }
                    else if (board[i, j] == 1)
                    {
                        count++;
                        Console.WriteLine("x |");
                    }
                    else
                        Console.WriteLine(" |");
                }
                Console.WriteLine("|");
            }
            if (count == 9)
            {
                isEmpty = false;
            }
            Console.WriteLine("--------------");
        }
        public void putVal()
        {
            Random rand = new Random();
            int i, j;
            if (player % 2 == 1)
            {

                i = (int)(rand.Next() * 10) % 3;
                j = (int)(rand.NextDouble() * 10) % 3;
            }
            else
            {
                Console.WriteLine("enter value");
                i = Convert.ToInt32(Console.ReadLine());
                j = Convert.ToInt32(Console.ReadLine());
            }
            if (board[i, j] == -10)
            {
                if (player % 2 == 0)
                {
                    board[i, j] = 0;
                }
                else
                {
                    board[i, j] = 1;
                    Console.WriteLine("computer choosing" + " " + i + " " + j);
                }

            }
            else
                putVal();
        }

        public bool win()
        {
            return ((board[0, 0] + board[0, 1] + board[0, 2] == player * 3)
            || (board[1, 0] + board[1, 1] + board[1, 2] == player * 3)
            || (board[2, 0] + board[2, 1] + board[2, 2] == player * 3)
            || (board[0, 0] + board[1, 0] + board[2, 0] == player * 3)
            || (board[0, 1] + board[1, 1] + board[2, 1] == player * 3)
            || (board[0, 2] + board[1, 2] + board[2, 2] == player * 3)
            || (board[0, 0] + board[1, 1] + board[2, 2] == player * 3)
            || (board[2, 0] + board[1, 1] + board[0, 2] == player * 3));
        }

        public void play()
        {
            initBoard();
            while (isEmpty)
            {
                Console.WriteLine("players turn");
                putVal();
                display();
                if (win())
                {
                    Console.WriteLine("players won");
                    return;
                }
                player = 1;
                Console.WriteLine("computer turn");
                putVal();
                display();
                if (win())
                {
                    Console.WriteLine("computer won");
                    return;
                }
                player = 0;
            }
        }

        //binary search
        public int binarySearch(int[] arr, int key, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    return binarySearch(arr, key, left, mid - 1);
                }
                else
                {
                    return binarySearch(arr, key, mid + 1, right);
                }
            }
        }

        //binary search of strings
        public int binarystringsearch(string[] arr, string key, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    return ++mid;
                }
                else if (res < 0)
                {
                    return binarystringsearch(arr, key, left, mid - 1);
                }
                else
                {
                    return binarystringsearch(arr, key, mid + 1, right);
                }
            }
        }

        //insertion sort of integers
        public void insertionsort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //insertion sort of strings
        public void insertionsort(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                String key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public void printArray(String[] sarr)
        {
            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine(sarr[i]);
            }
        }

        //bubble sort of integers
        public void bubblesort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //bubble sort of strings
        public void bubblesort(String[] arr)
        {
            String temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[i]) < 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
        }
        //generating primes
        public bool isPrimeNo(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void prime(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (isPrimeNo(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        //anagram
        public void anagram(String str1, String str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("not anagrams :length");
            }
            else
            {
                char[] c1 = str1.ToLower().ToCharArray();
                char[] c2 = str2.ToLower().ToCharArray();
                Array.Sort(c1);
                Array.Sort(c2);
                string val1 = new string(c1);
                string val2 = new string(c2);
                if (val1 == val2)
                {
                    Console.WriteLine(" anagrams");
                }
                else
                {
                    Console.WriteLine("not anagrams");
                }
            }
        }
        public static int[] count(int n)
        {
            int[] count = new int[10];
            int temp = n;
            while (temp != 0)
            {
                int rem = temp % 10;
                count[rem]++;
                temp = temp / 10;
            }
            return count;
        }
        public static bool anagram(int n1, int n2)
        {
            int[] x = count(n1);
            int[] y = count(n2);
            for (int i = 0; i < y.Length; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void primeAnagrams(int n)
        {
            List<int> ar = new List<int>();
            bool var;
            for (int i = 0; i <= n; i++)
            {
                var = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        var = false;
                        break;
                    }
                }
                if (var)
                    ar.Add(i);
            }
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = 1; j < ar.Count; j++)
                {
                    if (anagram(ar[i], ar[j]))
                    {
                        Console.WriteLine(ar[i] + " " + ar[j]);
                    }
                }
            }
        }
        public static bool isPallindrome(int n)
        {
            int temp = n; int sum = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                sum = sum * 10 + rem;
                temp = temp / 10;
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }
        public static void primePallindrome(int n)
        {
            bool var;
            for (int i = 2; i <= n; i++)
            {
                var = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (j % i == 0)
                    {
                        var = false;
                        break;
                    }
                }
                if (var && isPallindrome(i))
                    Console.WriteLine(i + " ");
            }
        }
    }
}
