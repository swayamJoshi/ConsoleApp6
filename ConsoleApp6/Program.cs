using System;
using System.Diagnostics;


namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);


            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();
            // write your self-reflection here as a comment
            //I have learnt the following:
            //1) Looping constructs and concepts
            //2) Nested Loops
            //3) Airthmatic and Logical Operators
            //4) Also learnt indentation and formatting
            //5) Also learnt deugging skills
            //6) Also learnt packaginf structures and default pachages

        }



        //modified
        public static bool isPrime(int q)
        {
            bool isPrime = false;
            for (int i = 2; i < q; i++)
            {
                if (q % i == 0)                         //logic to calculate Prime Nubers
                {
                    isPrime = false;
                    break;

                }
                else
                {
                    isPrime = true;

                }
            }
            return isPrime;
        }
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {

                    if (isPrime(i) == true)
                    {
                        Console.WriteLine(+i + "\t");                        //logic to print Prime Nubers
                    }

                }
                //Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }

        }


        public static double factorial(int i)
        {
            int a = 1;
            for (int n = 1; n <= i; n++)
            {
                a *= n;
            }
            return a;
        }
        public static double getSeriesResult(int n)
        {
            try
            {
                double a = 0;                    //initializing the variables
                double b = 0;
                double prod1 = 0;
                double prod2 = 0;


                for (int p = 1; p <= n; p += 2)
                {
                    prod1 = factorial(p) / (p + 1);                 //Calculating First even value, and the sequence
                    a += prod1;

                }
                for (int p = 2; p <= n; p += 2)                     //Calculating First odd value, and the sequence
                {
                    prod2 = factorial(p) / (p + 1);     
                    b += prod2;

                }

                return Math.Round(a - b, 3);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                long rem = 0;
                long divd = n;
                String str = "";
                for (; divd > 0;)
                {
                    rem = divd % 2;                         //logic to coverts as given in steps
                    str += rem;
                    divd /= 2;
                }
                return Convert.ToInt64(str);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {


            try
            {
                String str = n.ToString();
                int a = 1;
                int b = 0;                                                  // logic to coverts as given in steps
                for (int p = str.Length - 1; p >= 0; p--)   
                {
                    if (str[p] == '1')
                    {
                        b += a;
                    }
                    a *= 2;
                }
                return (Convert.ToInt64(b));

            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int b = n; b >= a; b--)
                    {
                        Console.Write(" ");             //printing spaces
                    }
                    for (int c = 1; c <= a; c++)
                    {
                        Console.Write("* ");                //printing stars
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                int count;
                int arLen = a.Length;
                int[] rep = new int[arLen];                 //Initializing an array to hold the frequency values
                for (int p = 0; p < arLen; p++)
                {
                    rep[p] = -1;
                }

                for (int p = 0; p < arLen; p++)                     //Logic to compute the frequency
                {
                    count = 1;
                    for (int q = p + 1; q < arLen; q++)
                    {
                        if (a[p] == a[q])
                        {
                            count++;
                            rep[q] = 0;
                        }
                    }
                    if (rep[p] != 0) ;
                    {
                        rep[p] = count;
                    }
                }

                Console.Write("Frequency of element: \n");
                Console.Write("Number \t Frequency \n");
                for (int p = 0; p < arLen; p++)                             //printing the output as a table
                {
                    if (rep[p] != 0)
                    {
                        Console.Write(a[p] + "\t" + rep[p] + "\n");
                    }
                }
                Console.ReadKey();

            }

            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

