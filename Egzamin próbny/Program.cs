using System;
namespace Egzamin_próbny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                checked
                {
                    Console.WriteLine(a+b+c);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argument exception, exit");
            }
            catch(FormatException)
            {
                Console.WriteLine("format exception, exit");
            }
            catch(OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
            }
            catch
            {
                Console.WriteLine("non supported exception, exit");
            }

        }
    }
}