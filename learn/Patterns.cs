namespace learn;

public class Patterns
{
    public static void Pattern(int n)
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
    public static void Pattern2(int n)
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
    public static void Pattern3()
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
    public static void Pattern4()
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
    public static void Pattern5(int n)
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
    public static void Pattern6(int n)
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
    public static void Pattern7(int n)
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
    public static void Pattern8(int n)
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
    public static void Pattern9(int n)
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
    public static void Pattern10(int n)
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

        Pattern8(n);
        Pattern9(n);
    }
    public static void Pattern11(int n)
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
    public static void Pattern12(int n)
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
    public static void Pattern13(int n)
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
    public static void Pattern14(int n)
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
    public static void Pattern15(int n)
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
    public static void Pattern16(int n)
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
    public static void Pattern17(int n)
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
    public static void Pattern18(int n)
    {
        //   Print the following pattern:
        //          A        
        //        A B A      
        //      A B C B A    
        //    A B C D C B A  
        //  A B C D E D C B A

        for (int i = 0; i <= n-1; i++) {
            for(int j = 1; j < n-i; j++) {
                Console.Write(' ');
            }

            char ch = 'A';
            int breakpoint = (2 * i + 1) / 2;

            for (int j = 1; j <= 2 * i + 1; j++) {
                Console.Write(ch);

                // Increment or decrement character
                if (j <= breakpoint) ch++;
                else ch--;
            }

            for (int j = 1; j < n - i; j++) {
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
    public static void Pattern19(int n)
    {
        //   Print the following pattern:
        //   E 
        //   D E
        //   C D E
        //   B C D E
        //   A B C D E

        for (int i = 0; i < n; i++) {
            for (int j = i; j >= 0; j--) {
                Console.Write((char)('E' - j));
            }
            Console.WriteLine();
        }
    }
    public static void Pattern20(int n)
    {
        //   Print the following pattern:
        //   * * * * * * * * * *
        //   * * * *     * * * *
        //   * * *         * * *
        //   * *             * *
        //   *                 *
        //   *                 *
        //   * *             * *
        //   * * *         * * *
        //   * * * *     * * * *
        //   * * * * * * * * * *

        for (int i = 0; i < 2*n; i++) {
            if (i < n) {
                for (int j = n; j > 0; j--) {
                    if (j <= i) Console.Write("-");
                    else Console.Write("*");
                }

                for (int k = 0; k < n; k++) {
                    if (k < i) Console.Write("-");
                    else Console.Write("*");
                }
            }
            if ( i >= n) {
                for (int l = 0; l < n; l++) {
                    if (i - n >= l) Console.Write("*");
                    else Console.Write("-");
                }

                for (int m = n; m > 0; m--) {
                    if (m <= i - n + 1) Console.Write("*");
                    else Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        // Method 2 - Simple
        // 5 stars    0 spaces     5 stars
        // 4 stars    2 spaces     4 stars
        // 3 stars    4 spaces     3 stars
        // 2 stars    6 spaces     2 stars
        // 1 stars    8 spaces     1 stars
        //------------------------------------------------ Symmetry 
        // 1 stars    8 spaces     1 stars
        // 2 stars    6 spaces     2 stars
        // 3 stars    4 spaces     3 stars
        // 4 stars    2 spaces     4 stars
        // 5 stars    0 spaces     5 stars

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-------------------------------------");
        int spaces = 0;
        for (int i = 0; i < n;i++) {
            for (int j = 0; j < n - i; j++) {
                Console.Write("*");
            }
            for (int k = 0; k < spaces; k++) {
                Console.Write(' ');
            }
            for (int l = 0; l < n-i; l++) {
                Console.Write("*");
            }
            spaces += 2;
            Console.WriteLine();
        }

        int spc = 2*n - 2;
        for (int i = 0; i < n;i++) {
            for (int j = 0; j <= i; j++) {
                Console.Write("*");
            }
            for (int k = 0; k < spc; k++) {
                Console.Write(' ');
            }
            for (int l = 0; l <= i; l++) {
                Console.Write("*");
            }
            spc -= 2;
            Console.WriteLine();
        }
    }
    public static void Pattern21(int n)
    {
        //   Print the following pattern:
        //   * * * *
        //   *     *
        //   *     *
        //   * * * *

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == 0 || j == 0 || i == n-1 || j == n-1) {
                    Console.Write("* ");
                } else {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
