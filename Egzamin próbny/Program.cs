public static double Srednia(int[,] tab)
{

    if (tab == null || tab.Length == 0)
        return 0.00;

    double sum = 0;
    int count = 0;

    foreach (var item in tab)
    {
        if (item > 0)
        {
            sum += item;
            count++;
        }
    }

    if (count == 0)
        return 0.00;

    return Math.Round(sum / count, 2);
}
