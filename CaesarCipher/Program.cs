/*
    → Julius Caesar protected his confidential information by encrypting it using a cipher.
    → Caesar's cipher shifts each letter by a number of letters.
    → If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet.
    → In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.

        Original alphabet:      abcdefghijklmnopqrstuvwxyz
        Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
*/

Console.WriteLine(caesarCipher("Always-Look-on-the-Bright-Side-of-Life", 5));

static string caesarCipher(string s, int k)
{
    if (k == 0) return s;

    var charArr = new char[s.Length];

    for (int i = 0; i < s.Length; ++i)
    {
        char ch = s[i];
        // 'a' → 97
        if (ch >= 'a' && ch <= 'z')
            ch = (char)(97 + ((ch + k - 97) % 26));
        // 'A' → 65
        else if (ch >= 'A' && ch <= 'Z')
            ch = (char)(65 + ((ch + k - 65) % 26));
        charArr[i] = ch;
    }
    return new String(charArr);

    // → ...
    // var stringBuilder = new StringBuilder();

    // foreach (var c in s)
    // {
    //     if (!char.IsLetter(c))
    //         stringBuilder.Append(c);
    //     else
    //     {
    //         char root = char.IsUpper(c) ? 'A' : 'a';
    //         int ascii = (c - root + k) % 26 + root;
    //         stringBuilder.Append((char)ascii);
    //     }
    // }
    // return stringBuilder.ToString();
}

/*
    + protect _                             → _yı korumak
    + confidential information              → gizli bilgi
    + by encrypting _                       → _yı şifreleyerek
    + using a cipher                        → şifreleme kullanarak
    + Caesar's cipher                       → Caesar'ın şifrelemesi
    + shift _                               → _yı kaydırmak, ötelemek
    + shift                                 → kaydırma, geçiş
    + take _ past the end of the alphabet   → _yı alfabenin sonuna götürmek
    + rotate                                → dönmek
    + rotate back to                        → _ya geri dönmek
    + the front of the alphabet             → alfabenin başı
    + In the case of ...                    → ... durumunda
    + a rotation by 3                       → üçlük bir rotasyon
    + map to ...                            → ...yla eşleşmek
*/
