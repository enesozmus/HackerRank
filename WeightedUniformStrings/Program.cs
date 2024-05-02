/*
    → A weighted string is a string of lowercase English letters where each letter has a weight.
    → Character weights are 1 to 26 from...
        a 1
        b 2
        ..
        ..
        y 25
        z 26
    → The weight of a string is the sum of the weights of its characters.
        apple       1 + 16 + 16 + 12 + 5

    → A uniform string consists of a single character repeated zero or more times.
    → For example, ccc and a are uniform strings, but bcb and cd are not.

    → Given a string, s, let U be the set of weights for all possible uniform contiguous substrings of string s.
    → There will be n queries to answer where each query consists of a single integer.
    → Create a return array where for each query, the value is "Yes" if query[i] ∈ U.
    → Otherwise, append "No".
*/

// char a = 'a';                     // ASCII code 97  -   96      1
// char b = 'b';                     // ASCII code 98  -   96      2
// char c = 'c';                     // ASCII code 99  -   96      3
// int integerValue = c - 0;
// Console.WriteLine(integerValue);

string s = "abccddde";
List<int> queries = new List<int> { 6, 1, 3, 12, 5, 9, 10 };

weightedUniformStrings(s, queries);

static List<string> weightedUniformStrings(string s, List<int> queries)
{
    HashSet<int> weights = new();
    var currentWeight = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1 && s[i] == s[i + 1])
        {
            currentWeight += s[i] - 96;
            weights.Add(currentWeight);
        }
        else
        {
            weights.Add(currentWeight + s[i] - 96);
            currentWeight = 0;
        }
    }

    List<string> result = new();
    for (int i = 0; i < queries.Count; i++)
    {
        if (weights.Contains(queries[i]))
        {
            result.Add("Yes");
            continue;
        }
        result.Add("No");
    }
    return result;
}

/*
    + lowercase                         → küçük harf
    + letter                            → harf
    + weight                            → ağırlık
    + the weight of a string            → bir string'in ağırlığı
    + the sum of the weights            → ilgili ağırlıkların toplamı
    + consist of ...                    → ...dan meydana gelmek
    + .... repeated zero or more times  → sıfır veya daha fazla tekrarlanan ...
    + let ... be ____                   → ... ____ olsun
    + the set of weights                → ağırlıkların kümesi
    + uniform                           → tek tip, tek biçimli, tekdüze
    + contiguous                        → bitişik, kesintisiz, peşi sıra gelen, araya parça karışmamış olan
    + all possible uniform contiguous   → mümkün olan bütün tek biçimli bitişikler
    + substring                         → alt string
    + query                             → sorgu
*/
