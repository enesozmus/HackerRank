/*
    → Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
    → Print the decimal value of each fraction on a new line with "6" places after the decimal.

    [1, 1, 0, -1, -1]

     two positive,          → 2/5       → 0,400000
     two negative,          → 2/5       → 0,400000
     one zero.              → 1/5       → 0,200000
*/

List<int> _numbers = new List<int> { 1, 1, 0, -1, -1 };

plusMinus(_numbers);


static void plusMinus(List<int> arr)
{
    double _positive = 0;
    double _negative = 0;
    double _zero = 0;

    for (int i = 0; i < arr.Count(); i++)
    {
        if (arr[i] > 0)
        {
            _positive++;
        }
        else if (arr[i] < 0)
        {
            _negative++;
        }
        else
        {
            _zero++;
        }
    }

    Console.WriteLine(_positive / arr.Count);
    Console.WriteLine(_negative / arr.Count);
    Console.WriteLine(_zero / arr.Count);
}

/*
    + given an array of integers                → bir tam sayı dizisi verildiğinde

    + calculate                                 → _yı hesaplamak

    + the ratios of its elements                → elemanları(nın) oranları

    + that are positive, negative, and zero     → pozitif, negatif ve sıfır olan

    + Print                                     → _yı yazdırmak

    + the decimal value of each fraction        → her kesrin ondalık değeri

    + with "6" places after the decimal         → virgülden sonra 6 basamklı (olacak şekilde)
*/