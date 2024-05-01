/*
    → A pangram is a string that contains every letter of the alphabet.
    → Given a sentence determine whether it is a pangram in the English alphabet.
    → Ignore case.
    → Return either "pangram" or "not pangram" as appropriate.

        We promptly judged antique ivory buckles for the next prize
            pangram
            not pangram


*/
Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the next prize"));

static string pangrams(string s)
{
    var set = new HashSet<char>();
    foreach (var c in s.ToLower())
    {
        if(char.IsLetter(c))
        {
            set.Add(c);
        }
    }
    return set.Count == 26 ? "pangram" : "not pangram";
}

/*
    + a string that ...                 → ...şöyle şöyle... bir string
    + contain ...                       → ...yı içermek
    + every letter of the alphabet      → alfabenin her harfi
    + given a sentence                  → bir cümle verildiğinde, verilen cümle
    + determine ...                     → ..yı saptamak, belirlemek, tanımlamak
    + whether                           → -ip -mediğini, -meyip -mediği, -ip -mediğini
    + whether it is a pangram           → bir pangram olup olmadığını
    + ignore ...                        → ...yı göz ardı etmek
    + case                              → büyük/küçük harf
    + pangram                           → bir dilin alfabesindeki tüm harflerin kullanılmasıyla oluşturulan cümle, mısra v.b.
*/