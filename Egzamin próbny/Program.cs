public static void Wzorek(int n)
{

    int x, y, z = 0;

    var c = n / 2;

    if (n % 2 == 0)
    {
        for (x = c; x >= 1; x--)
        {

            for (y = c; y > x; y--)
            {
                Console.Write(" ");
            }

            for (z = 1; z < (x * 2); z++)
            {
                Console.Write("*");
            }

            Console.Write('\n');
        }
    }
    else
    {
        for (x = c + 1; x >= 1; x--)
        {

            for (y = c + 1; y > x; y--)
            {
                Console.Write(" ");
            }

            for (z = 1; z < (x * 2); z++)
            {
                Console.Write("*");
            }

            Console.Write('\n');
        }
    }
}