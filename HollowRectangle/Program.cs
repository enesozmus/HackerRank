int n = Convert.ToInt32(Console.ReadLine());

hollowRectangle(n);

/*
    *****
    *   *
    *   *
    *   *
    *   *
    *   *
    *****
*/
static void hollowRectangle(int n)
{
    for (int i = 0; i < n; i++)
        Console.Write("*");
    Console.WriteLine();

    // row-line
    for (int i = 0; i < n; i++)
    {
        // column
        Console.Write("*");
        for (int y = 0; y < n - 2; y++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
        Console.Write("*");
}
