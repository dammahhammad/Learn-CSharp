namespace learn;

public class BasicRecursion
{
    public static void PrintNames(int n, string name)
    {
        if (n == 0) return;
        Console.WriteLine(name);
        n--;
        PrintNames(n, name);
    }
    public static void PrintNumberDesc(int n)
    {
        if (n == 0) return;
        Console.WriteLine(n);
        n--;
        PrintNumberDesc(n);
    }
    public static void PrintNumberAsc(int current, int n)
    {
        if (current > n) return;
        Console.WriteLine(current);
        PrintNumberAsc(current + 1, n);
    }
    public static int Sum(int n)
    {
        if (n == 0) { return 0; }
        int sum = n + Sum(n - 1);
        return sum;
    }
    public static int Factorial(int n)
    {
        if (n == 1) { return 1; }
        int factorial = n * Factorial(n - 1);
        return factorial;
    }
    public static void ReverseArray(List<int> list)
    {
        int p1 = 0;
        int p2 = list.Count - 1;

        while (p1 < p2) {
            // use tuple to swap values
            (list[p2], list[p1]) = (list[p1], list[p2]);

            //var temp = list[p1];
            //list[p1] = list[p2];
            //list[p2] = temp;

            p1++;
            p2--;
        }

        Console.WriteLine(string.Join(", ", list));
    }
    public static void PalindromeString(string text)
    {
        int p1 = 0;
        int p2 = text.Length - 1;
        var isPalindrome = true;

        while (p1 < p2) {
            if (text[p1] != text[p2]) isPalindrome = false;

            p1++;
            p2--;
        }

        Console.WriteLine(isPalindrome);
    }
    public static bool PalindromeStringRecursion(int num, string text)
    {
        if (num >= text.Length / 2) return true;

        if (text[num] != text[text.Length - num - 1]) return false;

        return PalindromeStringRecursion(num + 1, text);
    }
    public static void Fibonacci(int num)
    {
        int[] fib = new int[num + 1];  // Array to hold Fibonacci numbers
        fib[0] = 0;
        fib[1] = 1;

        // Compute Fibonacci numbers from index 2 to n
        for (int i = 2; i <= num; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        Console.WriteLine("The Fibonacci Series up to " + num + "th term:");

        for (int i = 0; i <= num; i++) {
            Console.WriteLine(fib[i] + " ");
        }
    }
    public static void Fibonacci2(int num)
    {
        var last = 0;
        var secondLast = 1;

        // Compute Fibonacci numbers from index 2 to n
        Console.Write(last + " " + secondLast);

        for (int i = 2; i <= num; i++) {

            var curr = last + secondLast;
            Console.Write(" " + curr);
            last = secondLast;
            secondLast = curr;
        }
    }
}
