/*
    → In this challenge, you are required to calculate and print the sum of the elements in an array,
    → keeping in mind that some of those integers may be quite large.

    → Complete the aVeryBigSum() function in the editor below.
    → It must return the sum of all array elements.
*/

List<long> _input = new List<long>() { 1, 2, 3, 4, 5 };

Console.WriteLine(aVeryBigSum(_input));


static long aVeryBigSum(List<long> ar) => ar.Sum();
// {
    // long _total = 0;

    // for (int i = 0; i < ar.Count; i++)
    // {
    //     _total = _total + ar[i];
    // }

    // return _total;

    // long _sum = ar.Sum(x => Convert.ToInt64(x));
    
    // return _sum;

    // return ar.Sum();
// }

/*
    + you are required to                   → ...yı yapman gerekir

    + calculate and print                   → hesaplamak ve yazdırmak

    + the sum of the elements in an array   → bir dizideki elemanların toplamı

    + keeping in mind that                  → ...yı aklında tut

    + some of those integers                → bu tam sayılardan bazıları

    + quite large                           → oldukça büyük

    + the sum of all array elements         → dizinin tüm elemanlarının toplamı

*/