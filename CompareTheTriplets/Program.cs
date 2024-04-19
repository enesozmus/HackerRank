/*

    → Alice and Bob each created one problem for HackerRank.
    → A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

        a = (a[0], a[1], a[2])
        b = (b[0], b[1], b[2])

    → The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

        If a[i] > b[i], then Alice is awarded 1 point.
        If a[i] < b[i], then Bob is awarded 1 point.
        If a[i] = b[i], then neither person receives a point.

    a = [1, 2, 3]
    b = [3, 2, 1]

        return [1, 1]

*/
List<int> _alice = new List<int> { 9, 1, 1, 9};
List<int> _bob = new List<int> { 1, 1, 1, 1 };


List<int> _result = compareTriplets(_alice, _bob);

Console.WriteLine($"{_result[0]} , {_result[1]}");


static List<int> compareTriplets(List<int> a, List<int> b)
{
    int _totalA = 0;
    int _totalB = 0;

    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > b[i])
        {
            _totalA++;
        }
        else if (a[i] == b[i])
        {
            continue;
        }
        else
        {
            _totalB++;
        }
    }
    List<int> _result = new List<int>();

    _result.Add(_totalA);
    _result.Add(_totalB);

    return _result;
    // return [_totalA, _totalB];
}

// ...
// solution 2
List<int> _result2 = compareTriplets2(_alice, _bob);
Console.WriteLine($"{_result2[0]} , {_result2[1]}");

static List<int> compareTriplets2(List<int> a, List<int> b)
{

    List<int> _result = new List<int>
    {
        Enumerable.Range(0, a.Count).Sum(i => (a[i] > b[i]) ? 1 : 0),
        Enumerable.Range(0, a.Count).Sum(i => (a[i] < b[i]) ? 1 : 0)
    };

    return _result;
}


/*
    + reviewer                      → incelemeci, eleştirmen, kitap eleştirmeni

    + rate                          → _yı derecelendirmek, _ya değer biçmek

    + award points                  → puan vermek, puanla ödüllendirmek

    + a scale from 1 to 100         → 1'den 100'e kadar ölçekte

    + problem clarity               → sorunun netliği

    + originality                   → özgünlük

    + difficulty                    → zorluk    

    + comparison points             → karşılaştırma noktaları

    + by comparing                  → ... karşılaştırarak
*/