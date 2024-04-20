/*
    → find and print
    → Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
    → Then print the respective minimum and maximum values as a single line of two space-separated long integers.

    arr = [1,3,5,7,9]

        → The minimum sum is        1 + 3 + 5 + 7
        → The maximum sum is        3 + 5 + 7 + 9
        → The function prints       16 24

    → Complete the miniMaxSum() function in the editor below.


*/

List<int> _list = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };

miniMaxSum(_list);


static void miniMaxSum(List<int> arr)
{
    long sum = 0;
    long minValue = long.MaxValue;
    long maxValue = long.MinValue;

    for (int i = 0; i < arr.Count; i++)
    {
        sum += arr[i];
        minValue = Math.Min(minValue, arr[i]);
        maxValue = Math.Max(maxValue, arr[i]);
    }
    // Console.WriteLine("= {0}", minValue);
    // Console.WriteLine("= {0}", maxValue);     
    Console.WriteLine($"{sum - maxValue} {sum - minValue}");
}

/*
    + given five positive integers              → beş pozitif tam sayı verildiğinde
    + exactly four of the five integers         → (tam olarak) ilgili beş tam sayıdan dördü
    + values that can be calculated by summing  → ...nın toplamı olarak hesaplanabilecek (hesaplanabilen) değerler
    + then                                      → daha sonra
    + print                                     → _yı yazdırmak
    + respective                                → ilgili
    + as a single line                          → tek bir satır olarak
    + space-separated                           → boşluklarla ayrışmış
    + two long integers                         → iki uzun tam sayı
*/
