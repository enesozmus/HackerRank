int n = Convert.ToInt32(Console.ReadLine());

hollowSquare(n);

/*
    * * * * * 
    *       * 
    *       * 
    *       * 
    * * * * * 
*/
static void hollowSquare(int n)
{
    for (int row = 0; row < n; row++)
    {
        for (int column = 0; column < n; column++)
        {
            if (row == 0 || column == 0 || row == n - 1 || column == n - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}
