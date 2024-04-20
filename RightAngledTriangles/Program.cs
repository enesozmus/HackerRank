int n = Convert.ToInt32(Console.ReadLine());

rightAngledTriAngle(n);
mirroredRightAngledTriAngle(n);
downwardRightAngledTriAngle(n);
mirroredDownwardRightAngledTriAngle(n);
hollowRightAngledTriAngle(n);


/*
    *      
    **     
    ***    
    ****   
    *****  
    ****** 
    *******
*/
static void rightAngledTriAngle(int n)
{
    for (int i = 0; i <= n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


/*
        *
       **
      ***
     ****
    *****
   ******
*/
static void mirroredRightAngledTriAngle(int n)
{
    // → 1
    for (int i = 1; i <= n; i++)
    {
        /*  
            * first row  (5-1) = 4 spaces
            * second row (5-2) = 3 spaces
            * third row  (5-3) = 2 spaces
            * and so on
        */
        for (int j = n - i; j >= 1; j--)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    // → 2
    for (int y = n - 1; y >= 0; y--)
    {
        for (int x = 0; x < n; x++)
        {
            if (x >= y)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}


/*
    ******
    ***** 
    ****  
    ***   
    **    
    * 
*/
static void downwardRightAngledTriAngle(int n)
{
    // → 1.
    for (int i = n; i >= 1; i--)
    {
        for (int y = 0; y < i; y++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    // → 2.
    for (int y = n - 1; y >= 0; y--)
    {
        for (int x = 0; x < n; x++)
        {
            if (x <= y)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    // → 3.
    for (int i = n - 1; i >= 0; i--)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


/*
    ******
     *****
      ****
       ***
        **
         *
*/
static void mirroredDownwardRightAngledTriAngle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < (n - i); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


/*
    *        
    **       
    * *      
    *  *     
    *   *    
    *    *   
    *     *  
    *      * 
    *********
*/
static void hollowRightAngledTriAngle(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j == 1 || i == j || i == n)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}