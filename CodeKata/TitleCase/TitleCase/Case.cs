using System.Collections.Generic;
using System.Linq;

namespace TitleCase
{
    public class Case
    {
        public static string TitleCaseMethod(string title, string minorWords = "")
        {
            if (string.IsNullOrWhiteSpace(title)) return title;

            var titleLowered = title.ToLower();
            var separatedTitleLowered = titleLowered.Split(" ");

            if (string.IsNullOrWhiteSpace(minorWords))
                minorWords = string.Empty;

            var minorLowered = minorWords.ToLower();
            var separatedMinorLowered = minorLowered.Split(" ");


            var result = new List<string>();
            foreach (var word in separatedTitleLowered)
            {
                if (!separatedMinorLowered.Contains(word))
                {
                    result.Add(FirstToUpper(word));
                    continue;
                }

                result.Add(word);
            }

            var resultSentence = FirstToUpper(string.Join(" ", result));
            return resultSentence;
        }

        public static string FirstToUpper(string givenWord)
        {
            var firstLetter = givenWord[0]
                .ToString()
                .ToUpper();

            var restOfWord = givenWord.Skip(1).Take(givenWord.Length);

            return firstLetter + string.Join("", restOfWord);
        }
    }
}