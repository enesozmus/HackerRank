/*
    → Louise joined a social networking site to stay in touch with her friends.
    → The signup page required her to input a name and a password. However, the password must be strong.
    → The website considers a password to be strong if it satisfies the following criteria:

        Its length is at least 6.
        It contains at least one digit.
        It contains at least one lowercase English character.
        It contains at least one uppercase English character.
        It contains at least one special character. The special characters are: !@#$%^&*()-+

    → She typed a random string of length n in the password field but wasn't sure if it was strong.
    → Given the string she typed, can you find the minimum number of characters she must add to make her password strong?

        numbers = "0123456789"
        lower_case = "abcdefghijklmnopqrstuvwxyz"
        upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        special_characters = "!@#$%^&*()-+"
*/

using System.Text.RegularExpressions;

Console.WriteLine(minimumNumber(11, "#HackerRank"));

static int minimumNumber(int n, string password)
{
    // → ...
    var result = 0;

    var regs = new List<string>(){
        @"[a-z]",
        @"[A-Z]",
        @"[0-9]",
        @"[!@#$%^&*()\-+]"
    };

    foreach (var r in regs)
    {
        if (!Regex.IsMatch(password, r))
            result++;
    }

    if (n >= 6 || n + result >= 6)
        return result;
    return 6 - n;


    // → ...
    // int digit = 0;
    // int upper = 0;
    // int lower = 0;
    // int special_char = 0;
    // int result = 0;

    // foreach (char i in password)
    // {
    //     if (char.IsNumber(i))
    //         digit++;
    //     else if (char.IsUpper(i))
    //         upper++;
    //     else if (char.IsLower(i))
    //         lower++;
    //     else
    //         special_char++;
    // }

    // if (digit == 0)
    //     result++;
    // if (upper == 0)
    //     result++;
    // if (lower == 0)
    //     result++;
    // if (special_char == 0)
    //     result++;
    // if (result + n > 6)
    //     return result;
    // else
    // {
    //     int addition = 6 - result - n;
    //     result += addition;
    //     return result;
    // }
}

/*
    + join ...                              → ...ya katılmak
    + a social networking site              → bir sosyal ağ sitesi
    + to stay in touch with ...             → ...yla ...larla temas halinde kalmak, iletişimde olmak
    + the signup page                       → kayıt sayfası
    + input                                 → bilgi sağlamak, girmek
    + require                               → gerekmek, talep etmek
    + consider                              → addetmek
    + if it satisfies ...                   → ...yı karşılıyorsa
    + the following criteria                → aşağıdaki kriterleri
    + a random string of length n           → n uzunluğunda rastgele bir string
    + the password field                    → şifre alanı
    + Given the string she typed            → yazdığı string göz önüne alındığında, yazdığı ilgili string verildiğinde
*/
