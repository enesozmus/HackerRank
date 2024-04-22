/*
    → Reduce a string of lowercase characters in range ascii[‘a’..’z’] by doing a series of operations.
    → In each operation, select a pair of adjacent letters that match, and delete them.

    → Delete as many characters as possible using this method and return the resulting string.
    → If the final string is empty, return Empty String
*/

// string s = Console.ReadLine();

string input = "aaabbcddde";        // → acde

Console.WriteLine(superReducedString(input));


static string superReducedString(string s)
{
    char[] input = s.ToCharArray();

    if (s.Length == 0)
        return "Empty String";
    else
    {
        int _ = 1;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i+1])
            {
                input[i] = '0';
                input[i+1] = '0';
                _ = 0;
                break;
            }
        }
        if (_ == 1 )
            return s;
        else
        {
            string str = "";
            foreach (char item in input)
            {
                if(item == '0')
                    continue;
                else
                    str+= item;
            }
            return superReducedString(str);
        }

    }

    // →
    // Stack<char> stack = new Stack<char>();

    // for (int i = 0; i < s.Length; i++)
    // {
    //     if (stack.Count > 0 && s[i] == stack.Peek())
    //     {
    //         stack.Pop();
    //     }
    //     else
    //     {
    //         stack.Push(s[i]);
    //     }
    // }
    // if (stack.Count == 0)
    //     return "Empty String";
    // else
    // {
    //     var str = "";
    //     while (stack.Count > 0)
    //     {
    //         str = stack.Pop() + str;
    //     }
    //     return str;
    // }
}

/*
    + reduce _                              → _yı azaltmak 
    + a string of lowercase characters      → küçük harf karakterlerden oluşan bir string
    + by doing a series of operations       → bir dizi işlem yaparak 
    + in range ...                          → ... aralığında 
    + in each operation,                    → her işlemde, 
    + select _                              → _yı seçmek 
    + a pair of ...                         → ...dan bir çift, bir ... çifti
    + a pair of adjacent letters            → bitişik harflerden bir çift
    + letters that match                    → eşleşen harfler
    + as many characters as possible        → mümkün olduğu kadar çok karakter
    + using this method                     → bu metotu kullanarak
    + the resulting string                  → sonuçta ortaya çıkan string, elde edilen string
*/