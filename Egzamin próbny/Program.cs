using System;
using System.Globalization;

namespace Egzamin_próbny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[,] {
                  { 1, 1, 1, 1, 1, 1 }
                , { 2, 2, 2, 2, 2, 2 }
                , { 3, 3, 3, 3, 3, 3 } };
            try
            {
                if (tab == null)
                {
                    //Console.WriteLine(0.0);
                    return 0.0;
                }
                else if (tab.Length == 0)
                {
                    //Console.WriteLine(0.0);
                    return 0.0;
                }
                else
                {
                    int ln = tab.Length;

                    double sum = 0;
                    foreach (int i in tab)
                    {
                        if (i >= 0)
                        {
                            sum += i;
                        }
                        else
                        {
                            ln--;
                        }


                    }
                    //Console.WriteLine(sum/tab.Length);
                    double avg = sum / ln;
                    return avg;
                }
            }
            catch
            {
                return 0.0;
            }
            
        }
    }
}