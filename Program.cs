using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Utility u = new Utility();
            //Leap year
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            u.leap(year);

            //flip coin
            u.flip();

            //power of 2
            Console.WriteLine("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            u.powerOf2(num);

            //harmonis value
            Console.WriteLine("enter number for calculating harmonic value ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine(u.harmonicValue(n1));
            }
            else
            {
                Console.WriteLine("value shold be positive");
            }

            //prime factors
            Console.WriteLine("enter number for prime factorization ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            u.primeFactor(n2);

            //gambler program
            Console.WriteLine("enter stake value ");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ur goal ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of trails ");
            int noOftrails = Convert.ToInt32(Console.ReadLine());
            u.gambler(stake, goal, noOftrails);

            //coupon code
            Console.WriteLine("coupon code is");
            u.couponcode();
            Console.ReadKey();

            //sum of three integers are zero
            Console.WriteLine("enter number ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array values ");
            int[] arr = new int[n3];
            for (int i = 0; i < n3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            u.sumOfThree(arr);

            //Distance program
            Console.WriteLine("enter value for x ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter value for y ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("distance is {0}", u.distance(x, y));

            //permuation
            Console.WriteLine("enter string ");
            string str = Console.ReadLine();
            int n = str.Length;
            u.stringPermutation(str);

            //quadtratic equation program
            Console.WriteLine("enter value of a,b ,c (ax2+bx+c=0) ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            u.quadratic(a, b, c);

            //windchill program
            Console.WriteLine("enter value of temp in fanhenheit ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter value of winf speed in miles per hour ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(u.windchill(t, v));

            //user input
            string temp = "Hello <<username>>, how r u";
            u.replaceName(temp);

            //monthly payment
            Console.WriteLine("enter value of P,Y,R ");
            double P = Convert.ToDouble(Console.ReadLine());
            double tm = Convert.ToDouble(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("payment {0}", u.monthlyPayment(P, tm, R));

            //sqrt
            Console.WriteLine("enter value ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(u.sqrt(C));

            //binary
            Console.WriteLine("enter number to convert into binary ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(u.binary(number));

            //binary swap
            Console.WriteLine("enter number to convert into binary ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(u.binary(numb));
            u.binaryswap(numb);

            //guessnumber
            Console.WriteLine("guess a number blw 127");
            Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("guessed number is" + u.guess());
            }
            catch (Exception e)
            {
                Console.WriteLine("guess a correct number");
            }

            //vending machine
            try
            {
                Console.WriteLine("enter amount");
                int value = Convert.ToInt32(Console.ReadLine());
                u.notes(value);
            }
            catch (Exception e)
            {
                Console.WriteLine("enter value in integer");
            }

            //taskscheduling
            Console.WriteLine("enter no of tasks");
            int tasks = Convert.ToInt32(Console.ReadLine());
            int[] dead = new int[tasks];
            int[] min = new int[tasks];
            for (int i = 0; i < min.Length; i++)
            {
                Console.WriteLine("task" + i + "time");
                min[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("task" + i + "deadline");
                dead[i] = Convert.ToInt32(Console.ReadLine());
            }

            //stopwatch
            Console.WriteLine("enter 1 to start");
            Convert.ToInt32(Console.ReadLine());
            u.startTime();
            Console.WriteLine("enter to stop");
            Convert.ToInt32(Console.ReadLine());
            u.stopTimer();
            u.elapsedTime();

            //tictoctoe
            u.play();

            //binary search of integers
            u.startTime();
            int[] ar = { 9, 5, 3, 0, 2, 1 };
            //int arr[]={0,1,2,3,5,9};
            Array.Sort(ar);
            int left = 0;
            int right = ar.Length - 1;
            Console.WriteLine("enter key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(u.binarySearch(ar, key, left, right));
            u.stopTimer();
            u.elapsedTime();

            //binary searchof strings
            u.startTime();
            string[] s = { "abc", "xvc", "g", "h", "gh", "l", "p" };
            Array.Sort<string>(s);
            int sleft = 0;
            int sright = s.Length - 1;
            Console.WriteLine("enter key");
            string ele = Console.ReadLine();
            Console.WriteLine(u.binarystringsearch(s, ele, sleft, sright));
            u.stopTimer();
            u.elapsedTime();

            //insertion sort of integers            
            int[] array = { 9, 5, 3, 0, 2, 1 };
            u.insertionsort(array);
            u.printArray(array);
            u.elapsedTime();

            //insertion sort of strings
            string[] sarr = { "abc", "xvc", "g", "h", "gh", "l", "p" };
            u.insertionsort(sarr);
            u.printArray(sarr);
            u.elapsedTime();

            //bubble sort of integers
            int[] arrays = { 9, 5, 3, 0, 2, 1 };
            u.bubblesort(arrays);
            u.elapsedTime();

            //bubble sort of strings
            string[] sar = { "abc", "xvc", "g", "h", "gh", "l", "p" };
            u.bubblesort(sar);
            u.elapsedTime();

            //prime number generation
            Console.WriteLine("generating primes");
            int nprime = Convert.ToInt32(Console.ReadLine());
            u.prime(nprime);

            //anagram
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            u.anagram(str1, str2);

            //anagram of numbers
            int an1 = Convert.ToInt32(Console.ReadLine());
            int an2 = Convert.ToInt32(Console.ReadLine());
            Utility.anagram(an1, an2);

            //primeAnagrams
            int an = Convert.ToInt32(Console.ReadLine());
            Utility.primeAnagrams(an);

            //isPallindrome
            Utility.isPallindrome(121);

            //pallindromic prime
            Utility.primePallindrome(100);

            Console.ReadKey();
        }
    }    
}
