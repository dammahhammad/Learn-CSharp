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
}
