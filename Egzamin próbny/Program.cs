using System.Xml;

namespace Egzamin_próbny
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int widthStat = int.Parse(Console.ReadLine());
            if(widthStat %2 == 0)
            {
                widthStat -= 1;
            }
            int width = widthStat;
            for(int x =widthStat; x> 0; x--)
            {
                
                Console.WriteLine();
                for (int i = x; x > 0; i--)
                {
                    if (width <= x)
                    {

                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}