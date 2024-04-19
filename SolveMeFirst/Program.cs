/*
    → Complete the function solveMeFirst to compute the sum of two integers.

    a = 7
    b = 3
        → return 10

    solveMeFirst has the following parameters:

    int a: the first value
    int b: the second value
        → return the sum of a and b

    1 <= a, b <= 1000  
*/

int _val1 = Convert.ToInt32(Console.ReadLine());
int _val2 = Convert.ToInt32(Console.ReadLine());

int _sum = solveMeFirst(_val1, _val2);

Console.WriteLine("= {0}", _sum);


static int solveMeFirst(int a, int b) => a + b;
// {
//     return a + b;
// }

/*
    + the sum of two integers       → iki tam sayının toplamı
    + compute                       → _yı hesaplamak
    + the following parameters      → aşağıdaki parametreler
*/