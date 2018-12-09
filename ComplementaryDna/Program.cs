using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ComplementaryDna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dnaa = "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCT...";
            var result = MakeComplement(dnaa);
            Console.WriteLine($"Result of {dnaa}: {result}");
            Console.ReadLine();
        }

        public static string MakeComplement(string dna)
        {
            var copyDna = new List<char>(new char[dna.Length]);
            
            for (int i = 0; i < dna.Length; i++)
            {
                var value = dna[i];
                if (value == 'A')
                {
                    ReplaceAt(copyDna, i, 'T');
                }
                else if (value == 'T')
                {
                    ReplaceAt(copyDna, i, 'A');
                }
            }
            
            for (int i = 0; i < dna.Length; i++)
            {
                var value = dna[i];
                if (value == 'G')
                {
                    ReplaceAt(copyDna, i, 'C');
                }
                else if (value == 'C')
                {
                    ReplaceAt(copyDna, i, 'G');
                }
            }

            var result = new string(copyDna.ToArray());
            return result;
        }

        public static void ReplaceAt(List<char> copyDna, int index, char insertedCharacter)
        {
            copyDna.Insert(index, insertedCharacter);
            copyDna.RemoveAt(++index);
        }
    }
}