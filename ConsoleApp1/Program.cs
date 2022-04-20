using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] a = s.AIntArray();
            int n = a[0];
            int m = a[1];
            s = Console.ReadLine();
            int[] b = s.AIntArray();
            int x = b[0];
            int y = b[1];
            string[,] arr = new string[n, m];
            int[,] irr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] arr2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    if (arr2[j] == "*")
                    {
                        if (i > 0)
                        {
                            if (j > 0)
                                irr[i - 1, j - 1] += 1;
                            irr[i - 1, j] += 1;
                            if (j < m)
                                irr[i - 1, j + 1] += 1;
                        }
                        if (i < n)

                        {
                            if (j > 0)
                                irr[i + 1, j - 1] += 1;
                            irr[i + 1, j] += 1;
                            if (j < m)
                                irr[i + 1, j + 1] += 1;
                        }
                        if (j > 0)
                            irr[i, j - 1] += 1;
                        if (j < m)
                            irr[i, j + 1] += 1;
                    }
                    arr[i, j] = arr2[j];
                }
            }



            for (int i = x-1; i < n; i++)
            {


                for (int j = y-1; j < m; j++)
                {

                    if (irr[i, j] == 0)
                    {
                        irr[i, j] = -1;
                    }
                    if (irr[i, j] > 0)
                    {
                        break;
                    }
                }
                for (int j = y-1; j > 0; j--)
                {
                    //Console.WriteLine(j);
                    if (irr[i, j] == 0)
                    {
                        irr[i, j] = -1;
                    }
                    if (irr[i, j] > 0)
                    {
                        break;
                    }
                }
            }

            for (int i = x-1; i > 0; i--)
            {


                for (int j = y-1; j < m; j++)
                {

                    if (irr[i, j] == 0)
                    {
                        irr[i, j] = -1;
                    }
                    if (irr[i, j] > 0)
                    {
                        break;
                    }
                }
                for (int j = y-1; j > 0; j--)
                {
                    if (irr[i, j] == 0)
                    {
                        irr[i, j] = -1;
                    }
                    if (irr[i, j] > 0)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (irr[i, j] == 0)
                    {
                        Console.Write("?");
                    }
                    else if (irr[i, j] > 0)
                    {
                        Console.Write(i);
                        
                    }
                    else
                    {
                        Console.Write("x");
                    }
                    Console.Write(' ');
                    
                }
                Console.WriteLine();
            }
        }


        void test()
        {
            int a = 0;
            string s = Console.ReadLine();
            while (s != "exit")
            {
                s = Console.ReadLine();
                if (s.Contains("ssh") && s.IndexOf(' ', 5) == -1 || a > 1)
                {
                    Console.WriteLine("baka");
                    goto baka;
                }
                s = Console.ReadLine();
                while (s == "rm log")
                {
                    s = Console.ReadLine();
                    a++;
                }
            }
            Console.WriteLine("yes");
        baka: int b = 0;
        }

    }

    public static class Doit
    {
        public static int AInt(this string s) => Convert.ToInt32(s);
        public static double ADouble(this string s) => Convert.ToDouble(s);
        public static int[] AIntArray(this string s) =>
            s.Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        public static void AOut(this object s) => Console.WriteLine(s);

    }
}
