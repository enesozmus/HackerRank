/*
    → You are in charge of the cake for a child's birthday.
    → You have decided the cake will have one candle for each year of their total age.
    → They will only be able to blow out the tallest of the candles.
    → Count how many candles are tallest.

    candles = [4,4,1,3]
        + The maximum height candles are 4 units high.
        + There are 2 of them, so return 2.
        → 2
*/

List<int> _list = new List<int>() { 7, 4, 4, 4, 1, 3, 5, 7, 7, 7 };

Console.WriteLine(birthdayCakeCandles(_list));


static int birthdayCakeCandles(List<int> candles)
{
    // int actuallyTallest = candles.Max();
    int tallest = 0;
    int count = 1;

    for (int i = 0; i < candles.Count; i++)
    {
        if (candles[i] > tallest)
        {
            tallest = candles[i];
            count = 1;
        }
        else if (candles[i] == tallest)
        {
            count++;
        }
    }
    return count;
    // return candles.Count(x => x == candles.Max());
}

/*
    + be in charge of _                         → ...dan sorumlu olmak
    + a child's birthday                        → bir çocuğun doğum günü
    + decide ...                                → ...ya karar vermek
    + candle                                    → mum
    + blow out                                  → üfleyip söndürmek
    + the tallest of the candles                → mumların en uzunu
    + count ...                                 → ...yı saymak
*/
