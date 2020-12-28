using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace RegularExpression
{
    public static class Program
    {

        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var number = CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" });
            System.Console.WriteLine($"Faces number: {number}");
            System.Console.ReadLine();
        }

        public static int CountSmileys(string[] smileys) 
        {
            return smileys.Count(x => _regex.IsMatch(x));
        }
    }
}
