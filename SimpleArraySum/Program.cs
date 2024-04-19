/*
    → Given an array of integers, find the sum of its elements.

        → For example, if the array ar = [1,2,3]
            return 1 + 2 + 3

    → Complete the simpleArraySum() function in the editor below.
    → It must return the sum of the array elements as an integer.

    → simpleArraySum has the following parameter(s):
            ar: an array of integers

            + The first line contains an integer, n, denoting the size of the array.
            + The second line contains n space-separated integers representing the array's elements.
*/


List<int> _list = new List<int>() { 1, 2, 3, 4, 10 };

int _result = simpleArraySum(_list);

Console.WriteLine("= {0}", _result);


static int simpleArraySum(List<int> ar) => ar.Sum();
// {
     // return ar.Sum();
     // int _total = 0;
     // for (int i = 0; i < ar.Count; i++)
     // {
     //     _total += ar[i];
     // }
     // return _total;
// }


/*

    + given                         → ...verildiğinde

    + an array of integers          → bir tam sayı dizisi

    + the sum of its elements       → ..nın elemanlarının toplamı

    + find                          → _yı bulmak

    + complete                      → _yı tamamlamak

    + the sum of the array elements → ilgili dizi elemanlarının toplamı

    + as an integer                 → bir integer olarak

    + the following parameters      → aşağıdaki parametreler

    + contain                       → _yı içermek

    + the size of the array         → ilgili dizinin boyutu

    + denote                        → _yı ifade eden, _ya delalat eden

    + the array's elements          → ilgili dizinin elemanları

    + represent                     → _yı temsil etmek

    + n space-separated integers    → n (sayıda) boşlukla ayrılmış
*/