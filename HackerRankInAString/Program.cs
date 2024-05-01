/*
    → We say that a string contains the word hackerrank if a subsequence of its characters spell the word hackerrank.
    → Remeber that a subsequence maintains the order of characters selected from a sequence.

    → More formally, let p[0], p[1], p[2], ....., p[9] be the respective indices of h, a, c, k, e, r, r, a, n, k in string s. If p[0] < p[1] < p[2] < ..... < p[9] is true, then s contains hackerrank.
    → For each query, print YES on a new line if the string contains hackerrank, otherwise, print NO.

        hereiamstackerrank
        YES
*/

Console.WriteLine(hackerrankInString("hhaacckkekraraannk"));

static string hackerrankInString(string s)
{
    string hacker = "hackerrank";
    string temp = "";
    int startIndex = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (temp == hacker)
            break;
            
        if (hacker[startIndex] == s[i])
        {
            temp += s[i];
            startIndex++;
            continue;
        }
    }
    if (temp == hacker)
        return "YES";
    else
        return "NO";
}

/*
    + say thay ...                      → ...yı söylemek
    + contain ...                       → ...yı içermek
    + subsequence                       → alt dizi
    + a subsequence of its characters   → (nın) karakterlerinin bir alt dizisi
    + spell ...                         → ...yı hecelemek
    + remember that ...                 → ...yı hatırlamak
    + maintain ...                      → ...yı sürdürmek, korumak, devam ettirmek
    + the order of ...                  → ...nın sırası
    + selected from ...                 → ...dan seçilen, ...lar arasından seçilen
    + for each query                    → her bir sorgu için
    + more formally                     → daha resmi olarak, daha şekilli teknik ifade edersek
    + let __ be ...                     → _ları ... varsaymak, _ ... olsun, öyle kabul edelim
    + the respective indices            → ilgili endeksler
*/
