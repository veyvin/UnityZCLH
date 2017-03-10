using System;
using static System.Console;

namespace csharp7
{
    static class RefReturns
    {
        public static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }

            throw new Exception($"{nameof(number)} not found");
        }


    }
}
