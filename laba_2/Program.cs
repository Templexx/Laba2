using System;

namespace laba_2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Входные данные (массив, строка или любой подобный тип)
            var inputData = new int[] { 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25 };
            var check = 24;
            var length = inputData.Length;
            Array.Sort(inputData, 0, length);
            var first = 0;
            var last = length - 1;
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
    }
}
//Специально для development