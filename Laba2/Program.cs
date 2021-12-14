using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входные данные (массив, строка или любой подобный тип)
            var inputData = InsertInputData();
            var check = InsertCheck();
            var length = inputData.Length;
            Array.Sort(inputData, 0, length);
            var first = 0;
            var last = length - 1;
            FaindPairs(first, last, inputData, check);
        }

        private static void FaindPairs(int first, int last, int[] inputData, int check)
        {
            while (first < last)
            {
                var s = inputData[first] + inputData[last];
                if (s == check)
                {
                    Console.Write(inputData[first]);
                    Console.Write(", ");
                    Console.Write(inputData[last]);
                    Console.Write("\n");
                    first++;
                    last--;
                }
                else if (s < check)
                {
                    first++;
                }
                else
                {
                    last--;
                }
            }
        }

        private static int InsertCheck()
        {
            var check = 24;
            return check;
        }

        private static int[] InsertInputData()
        {
            var inputData = new[] {2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25};
            return inputData;
        }
    }
}
//Специально для development