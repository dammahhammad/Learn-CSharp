namespace learn;

internal class Know_basic_maths
{
    public static void CountDigits(int num)
    {
        int count = 0;
        
        while (num > 0) {
            num = num / 10;
            count++;
        }

        Console.WriteLine(count);
    }

    public static void OptimizedCountDigits(int num)
    {
        int count = (int)(Math.Log10(num) + 1);

        Console.WriteLine(count);
    }

    public static void Reverse(int num)
    {
        string c = "";

        while (num > 0) {
            var temp = num % 10;
            num = num / 10;
            c = c + temp.ToString();
        }

        Console.Write(int.Parse(c));
    }

    public static void OptimizedReverse(int num)
    {
        int result = 0;

        while (num > 0) {
            var temp = num % 10;
            result = result*10 + temp;
            num = num / 10;
        }

        Console.Write(result);
    }

    public static void Palindrome(int num)
    {
        int result = 0;
        int temp = num;
        while (num > 0) {
            result = result * 10 + num % 10;
            num = num / 10;
        }

        if (result == temp) Console.Write(true);
    }
    public static void GCD(int a, int b)
    {
        var minNum = a > b ? b : a;
        var gcd = 1;

        for (int i = 1; i <= minNum; i++) {
            if (a % i == 0 && b % i == 0) { gcd = i; }
        }

        Console.Write(gcd);
    }


    /// <summary>
    /// Euclidean Algorithm:
    ///     The Euclidean Algorithm is a method for finding the greatest common divisor(GCD)
    ///     of two numbers.It operates on the principle that the GCD of two numbers remains
    ///     the same even if the smaller number is subtracted from the larger number.
    ///     To find the GCD of n1 and n2 where n1 > n2:
    ///     1. Repeatedly subtract the smaller number from the larger number until one of them becomes 0.
    ///     2. Once one becomes 0, the other is the GCD of the original numbers.
    ///     
    ///     Example:
    ///         n1 = 20, n2 = 15
    ///         gcd(20, 15) = gcd(20 - 15, 15) = gcd(5, 15)
    ///         gcd(5, 15)  = gcd(15 - 5, 5)  = gcd(10, 5)
    ///         gcd(10, 5)  = gcd(10 - 5, 5) = gcd(5, 5)
    ///         gcd(5, 5)   = gcd(5 - 5, 5)  = gcd(0, 5)
    ///         Hence, return 5 as the GCD.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static void EuclideanGCD(int a, int b)
    {
        while (a > 0 && b > 0) {
            if (a > b) a = a - b;
            else b = b - a;

            if (a == 0) Console.Write(b);
            if (b == 0) Console.Write(a);
        }
    }

    public static void Armstrong(int a)
    {
        var list = new List<double>();
        var copy = a;

        while (a > 0) {
            int temp = a % 10;
            list.Add(temp);
           a = a / 10;
        }

        double sum = 0;
        foreach (double i in list) {
            sum += Math.Pow(i, list.Count);
        }

        if (sum == copy) Console.WriteLine(true);
        else Console.WriteLine(false);

    }
    public static void OptimizedArmstrong(int a)
    {
        double sum = 0;
        int copy = a;
        int k = a.ToString().Length;

        while (a > 0) {
            int rem = a % 10;
            sum += Math.Pow(rem, k);
            a /= 10;
        }

        if (sum == copy) Console.WriteLine(true);
        else Console.WriteLine(false);
    }
    public static void AllDivisors(int a)
    {
        var list = new List<int>();

        for (int i = 1; i <= a; i++) {
            if (a % i == 0) list.Add(i);
        }

        Console.WriteLine(string.Join(", ", list));
    }
    public static void OptimizedAllDivisors(int n)
    {
        for (int i = 1; i * i <= n; i++) {
            if (n % i == 0) {
                Console.Write(i + " ");

                if (i != n / i) {
                    Console.Write((n / i) + " ");
                }
            }
        }
    }
}