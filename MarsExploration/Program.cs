/*
    → A space explorer's ship crashed on Mars!
    → They send a series of SOS messages to Earth for help.
    → Letters in some of the SOS messages are altered by cosmic radiation during transmission.
    → Given the signal received by Earth as a string, s, determine how many letters of the SOS message have been changed by radiation.

        SOSSPSSQSSOR
        3

        SOSSOSSOS
        0
*/

Console.WriteLine(marsExploration("SOSSPSSQSSOR"));

static int marsExploration(string s)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i % 3 == 0 || i % 3 == 2)
        {
            if (s[i] != 'S') count++;
        }
        else
        {
            if (s[i] != 'O') count++;
        }
    }
    return count;

    // var theNumberOfRepetitions = s.Length / 3;
    // var originalMessege = string.Empty;

    // for (int i = 0; i < theNumberOfRepetitions; i++)
    //     originalMessege += "SOS";

    // var diffCount = 0;

    // for (int i = 0; i < s.Length; i++)
    // {
    //     if (originalMessege[i] != s[i])
    //         diffCount++;
    // }
    // return diffCount;
}

/*
    + space explorer            → uzay araştırmacısı
    + crash on Mars             → Mars'a düşmek
    + letters                   → harfler
    + alter                     → değiştirmek, başkalaşmak
    + during transmission       → iletim sırasında
    + received by Earth         → Dünya tarafından alınan
    + determine _               → _yı belirlemek
*/
