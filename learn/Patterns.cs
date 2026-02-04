namespace learn;

public class Patterns
{
    public static void Alpha(int n)
    {
        //   Print the following pattern:
        //   * * * * *
        //   * * * * *
        //   * * * * *
        //   * * * * *
        //   * * * * *

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void Alpha2(int n)
    {
        //   Print the following pattern:
        //   *
        //   * *
        //   * * *
        //   * * * *
        //   * * * * *

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n; j++) {
                if (j <= i) Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha3()
    {
        //   Print the following pattern:
        //   1
        //   1 2
        //   1 2 3
        //   1 2 3 4
        //   1 2 3 4 5

        for (int i = 1; i <= 5; i++) {
            for (int j = 1; j <= 5; j++) {
                if (j <= i) Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public static void Alpha4()
    {
        //   Print the following pattern:
        //   1
        //   3 2
        //   3 3 3
        //   4 4 4 4
        //   5 5 5 5 5

        for (int i = 1; i <= 5; i++) {
            for (int j = 1; j <= 5; j++) {
                if (j <= i) Console.Write(i);
            }
            Console.WriteLine();
        }
    }
    public static void Alpha5(int n)
    {
        //   Print the following pattern:
        //   * * * * *
        //   * * * *
        //   * * *
        //   * *
        //   *

        for (int i = 0; i < n; i++) {
            for (int j = n; j > 0; j--) {
                if (i + j <= n) Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha6(int n)
    {
        //   Print the following pattern:
        //   * * * * *
        //   * * * *
        //   * * *
        //   * *
        //   *

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (j < n-i) Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha7(int n)
    {
        //   Print the following pattern:
        //   1 2 3 4 5
        //   1 2 3 4
        //   1 2 3
        //   1 2
        //   1

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n; j++) {
                if (j <= n-i+1) Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public static void Alpha8(int n)
    {
        //   Print the following pattern:
        //                *
        //              * * *
        //            * * * * *
        //          * * * * * * *
        //        * * * * * * * * *

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j < n - i + 1; j++) {
                Console.Write("- ");
            }

            for (int k = 0; k < 2 * i - 1; k++) {
                Console.Write("* ");
            }

            for (int l = 1; l < n - i + 1; l++) {
                Console.Write("- ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha9(int n)
    {
        //   Print the following pattern:
        //        * * * * * * * * *
        //          * * * * * * *
        //            * * * * *
        //              * * *
        //                *

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j < i; j++) {
                Console.Write("- ");
            }

            for (int k = 0; k < (2 * n) - (2*i-1); k++) {
                Console.Write("* ");
            }

            for (int l = 1; l < i; l++) {
                Console.Write("- ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha10(int n)
    {
        //   Print the following pattern:
        //                *
        //              * * *
        //            * * * * *
        //          * * * * * * *
        //        * * * * * * * * *
        //        * * * * * * * * *
        //          * * * * * * *
        //            * * * * *
        //              * * *
        //                *

        Alpha8(n);
        Alpha9(n);
    }
    public static void Alpha11(int n)
    {
        //   Print the following pattern:
        //   *
        //   * *
        //   * * *
        //   * * * *
        //   * * * * *
        //   * * * *
        //   * * *
        //   * *
        //   *

        for (int i = 1; i <= 2*n-1; i++) {
            int stars = i;
            if (i >= n) stars = 2 * n - i;

            for (int j = 1; j <= stars; j++) {
                Console.Write("* ");

            }
            Console.WriteLine();
        }
    }

    public static void Alpha12(int n)
    {
        //   Print the following pattern:
        //   1
        //   0 1
        //   1 0 1
        //   0 1 0 1
        //   1 0 1 0 1

        for (int i = 1; i <= n; i++) {
            int start = 1;
            if (i % 2 == 0) start = 0;

            for (int j = 1; j <= i; j++) {
                Console.Write(start);
                start = 1 - start;
            }
            Console.WriteLine();
        }
    }
    public static void Alpha13(int n)
    {
        //   Print the following pattern:
        //   1                 1
        //   1 2             2 1
        //   1 2 3         3 2 1
        //   1 2 3 4     4 3 2 1
        //   1 2 3 4 5 5 4 3 2 1

        for (int i = 1; i <= n; i++) {
            // Left numbers
            for (int j = 1; j <= i; j++) {
                Console.Write(j + " ");
            }

            // Spaces in the middle
            for (int s = 1; s <= 2 * (n - i); s++) {
                Console.Write("  ");
            }

            // Right numbers
            for (int j = i; j >= 1; j--) {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
    public static void Alpha14(int n)
    {
        //   Print the following pattern:
        //   1
        //   2 3
        //   4 5 6
        //   7 8 9 10
        //   11 12 13 14 15 
        int num = 1;
        for (int i = 1; i <= n; i++) {
            for(int j = 0; j < i; j++) {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
    public static void Alpha15(int n)
    {
        //   Print the following pattern:
        //   A
        //   A B
        //   A B C
        //   A B C D
        //   A B C D E

        for (int i = 1; i <= n; i++) {
            for(char j = 'A'; j < 'A'+ i; j++) {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha16(int n)
    {
        //   Print the following pattern:
        //   A B C D E
        //   A B C D
        //   A B C
        //   A B
        //   A

        for (int i = n; i >= 1; i--) {
            for(char j = 'A'; j < 'A'+ i; j++) {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
    public static void Alpha17(int n)
    {
        //   Print the following pattern:
        //   A
        //   B B
        //   C C C
        //   D D D D
        //   E E E E E

        for (int i = 0; i < n; i++) {
            for(int j = 0; j <= i; j++) {
                Console.Write((char)('A' + i));
            }
            Console.WriteLine();
        }
    }
    public static void Alpha18(int n)
    {
        //   Print the following pattern:
        //           A
        //         A B A
        //       A B C B A
        //     A B C D C B A
        //   A B C D E D C B A

        for (int i = 0; i < n; i++) {
            for(int j = 0; j <= i; j++) {
                Console.Write((char)('A' + i));
            }
            Console.WriteLine();
        }
    }
}
