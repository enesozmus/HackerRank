/*
    → This is a staircase of size n = 4
        #
       ##
      ###
     ####


    → Its base and height are both equal to n.
    → It is drawn using # symbols and spaces.
    → The last line is not preceded by any spaces.
    → Write a program that prints a staircase of size n.

    → Complete the staircase function in the editor below.
            + staircase has the following parameter(s):
                int n: an integer
                0 < n <= 100
*/

int n = Convert.ToInt32(Console.ReadLine());


staircase(n);

static void staircase(int n)
{
    // n kadar satır üretir
    for (int i = 0; i < n; i++)
    {
        // ilgili satırda yine n kadar boşluk, harf vs. üretir
        for (int j = 0; j < n; j++)
        {
            // → 1. tur
            // j 0 olarak başlar
            // i 0 olarak başlar
            // j < 4 - 0 - 1
            // j küçük olduğu sürece 3'den
            // _ _ _
            // _ _ _ # (j => 0 1 2 3)

            // → 2. tur
            // j yine 0 olarak başlar (bir önceki turda j kendini tamamladı)
            // i artık 1
            // j < 4 - 1 - 1
            //  küçük olduğu sürece 2'den
            // _ _
            // _ _ # #
            if (j < n - i - 1)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine();
    }
}

// ...
// solution 2
staircase2(n);
static void staircase2(int n)
{
    for (int y = n - 1; y >= 0; y--)
    {
        for (int x = 0; x < n; x++)
        {
            if (x >= y)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

// ...
// solution 3
staircase3(n);
static void staircase3(int n)
{
    // 4 kere döner
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(
          // → 1. tur
          // → 4 - 1
          // 3 kere boşluk atar bir kere # atar
          // → 2. tur
          // → 4 - 2
          // 2 kere boşluk atar iki kere # atar
          new String(' ', n - i)
          +
          new string('#', i));
    }
}


/*

    + a staircase of size n             → n boyutunda bir merdiven
    + Its base and height               → ...(nın) tabanı ve yüksekliği
    + be equal to                       → ..ya eşit olmak, denk olmak
    + It is drawn using                 → bu ... kullanılarak çizilir
    + be preceded by something          → ...dan sonra olmak/gelmek
    + a program that prints             → ... yazdıran bir program
*/
