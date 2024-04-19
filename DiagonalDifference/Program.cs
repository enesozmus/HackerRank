/*

    → Given a square matrix, calculate the absolute difference between the sums of its diagonals.

    1 2 3
    4 5 6
    9 8 9

    ( 1 + 5 + 9 ) - (3 + 5 + 9) = |15-17| => 2
*/
List<List<int>> _numbers = new List<List<int>>
{ 
    new List<int>(){1, 2, 3},
    new List<int>(){4, 5, 6},
    new List<int>(){7, 8, 9}
};

/*
    0,0     0,1     0,2
    1,0     1,1     1,2
    2,0     2,1     2,2  
*/

Console.WriteLine(_numbers.Count);          // → 3 
// Console.WriteLine(_numbers[0][0]);
// Console.WriteLine(_numbers[0][1]);
// Console.WriteLine(_numbers[0][2]);
// Console.WriteLine(_numbers[1][0]);
// Console.WriteLine(_numbers[1][1]);
// Console.WriteLine(_numbers[1][2]);
// Console.WriteLine(_numbers[2][0]);
// Console.WriteLine(_numbers[2][1]);
// Console.WriteLine(_numbers[2][2]);


int _result = diagonalDifference(_numbers);

Console.WriteLine(_result);
// | ( 1 + 5 + 9) - (3 + 5 + 7) | 
// | ( 15) - (15) |
// 0

static int diagonalDifference(List<List<int>> arr)
{
    int _leftDiagonal = 0;
    int _rightDiagonal = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        _leftDiagonal += arr[i][i];
        _rightDiagonal += arr[i][arr.Count - i - 1];
        // 3 - 0 - 1    2   →    0, 2
        // 3 - 1 - 1    1   →    1, 1
        // 3 - 2 - 1    0   →    2, 0
    }
    // mutlak değer döndürür
    return Math.Abs(_leftDiagonal - _rightDiagonal);
}

/*
    + Given a square matrix             → bir kare matris verildiğinde

    + calculate                         → _yı hesaplamak

    + the absolute difference           → mutlak fark

    + the sums of its diagonals         → köşegenlerinin toplamı

    + The left-to-right diagonal        → soldan sağa köşegen

*/
