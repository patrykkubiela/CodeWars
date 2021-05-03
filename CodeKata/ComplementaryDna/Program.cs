using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ComplementaryDna
{
    public static class Program
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
                copyDna.SwapDnaLeter(dna, i, 'A', 'T');
            }
            
            for (int i = 0; i < dna.Length; i++)
            {
                copyDna.SwapDnaLeter(dna, i, 'C', 'G');
            }

            var result = new string(copyDna.ToArray());
            return result;
        }

        private static void SwapDnaLeter(this List<char> listToChange, string dnaPattern, int index,
            char firstConditionValue, char secondConditionValue)
        {
            var value = dnaPattern[index];
            if (value == firstConditionValue)
            {
                ReplaceAt(listToChange, index, secondConditionValue);
            }
            else if (value == secondConditionValue)
            {
                ReplaceAt(listToChange, index, firstConditionValue);
            }
        }
        
        private static void ReplaceAt(List<char> copyDna, int index, char insertedCharacter)
        {
            copyDna.Insert(index, insertedCharacter);
            copyDna.RemoveAt(++index);
        }
    }
}