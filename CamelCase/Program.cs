/*
    → There is a sequence of words having the following properties:

        1. It is a concatenation of one or more words consisting of English letters.
        2. All letters in the first word are lowercase.
        3. For each of the subsequent words, the first letter is uppercase and rest of the letters are lowercase.
    
    → oneTwoThree

    → Given _s, determine the number of words in _s.
*/

// string s = Console.ReadLine();

string input = "saveChangesInTheEditor";

Console.WriteLine(camelcase(input));


static int camelcase(string s)
{
    int count = 1;

    foreach (var letter in s)
    {
        if(char.IsUpper(letter))
         count++;
    }
    return count;
}

/*
    + a sequence of words                   → bir kelime dizisi
    + having the following properties       → aşağıdaki özelliklere sahip
    + concatenation                         → bitiştirme, birleştirme
    + concatenation of ...                  → ...nın bitiştirilmesi, birleştirilmesi
    + consisting of ...                     → ...dan oluşan
    + English letters                       → İngilizce harfler
    + lowercase                             → küçük harf
    + uppercase                             → büyük harf
    + for each of the subsequent words      → ilgili sonraki kelimelerin her biri
    + rest of the letters                   → kalan harfler, harflerin kalanı
    + given ...                             → ... verildiğinde
    + determine ...                         → ...yı tanımlamak, belirlemek
*/