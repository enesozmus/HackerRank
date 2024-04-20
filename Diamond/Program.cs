int n = Convert.ToInt32(Console.ReadLine());

diamond(n);
halfDiamond(n);

/*
    *    
   ***   
  *****  
 ******* 
*********
 ******* 
  *****  
   ***   
    *
*/
static void diamond(int n)
{
    int count = n - 1;
    for (int j = 1; j <= n; j++)
    {
        for (int i = 1; i <= count; i++)
            Console.Write(" ");
        count--;
        for (int i = 1; i <= 2 * j - 1; i++)
            Console.Write("*");
        Console.WriteLine();
    }
    count = 1;
    for (int j = 1; j <= n - 1; j++)
    {
        for (int i = 1; i <= count; i++)
            Console.Write(" ");
        count++;
        for (int i = 1; i <= 2 * (n - j) - 1; i++)
            Console.Write("*");
        Console.WriteLine();
    }
}


/*
    *        
    **       
    ***      
    ****     
    ***** 
    ****     
    ***      
    **       
    * 
*/
static void halfDiamond(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = n - 1; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
