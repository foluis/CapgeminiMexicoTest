using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiMexicoCodingTest
{
    internal class ShortestLengthFirst : IExercice
    {
        public void Run()
        {
            //List<string> palabras1 = new List<string> { "casa", "elefante", "sol", "computadora", "mar" };
            //List<string> sorted1 = SortWordsByLength(palabras1);
            //Console.WriteLine(string.Join(", ", sorted1));
            //// Output: sol, mar, casa, elefante, computadora

            //List<string> palabras2 = new List<string> { "house", "elephant", "sun", "computer", "sea" };
            //List<string> sorted2 = SortWordsByLength(palabras2);
            //Console.WriteLine(string.Join(", ", sorted2));
            //// Output: sun, sea, house, elephant, computer

            List<string> palabras3 = new List<string> {"lord5","cielo6","río4","bosque7","ciudad7","avión6","playa6","libro6","familia8","universidad13"};
            List<string> sorted3 = SortWordsByLength(palabras3);
            Console.WriteLine(string.Join(", ", sorted3));
        }

        public static List<string> SortWordsByLength(List<string> words)
        {
            if (words == null)
            {
                return new List<string>();
            }
            
            return words
                .OrderBy(word => word.Length)
                .ToList();
        }
    }
}
