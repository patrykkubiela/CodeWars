using System;

namespace PersistenceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            int count = 0;
            return Count(n, ref count);
        }

        public static int Count(long n, ref int count)
        {
            string nAsText = n.ToString();
            var textLength = nAsText.Length;

            if (textLength == 1)
            {
                return count;
            }
            else
            {
                count++;
                long multiplyResult = 1;
                foreach (var number in nAsText)
                {
                    multiplyResult *= long.Parse(number.ToString());
                }

                return Count(multiplyResult, ref count);
            }
        }
    }
}
