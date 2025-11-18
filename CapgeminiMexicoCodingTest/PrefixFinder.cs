using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiMexicoCodingTest
{
    internal class PrefixFinder : IExercice
    {
        public void Run()
        {
            List<string> palabras = ["programar", "elefante", "producto", "computer", "mar", "caspa", "compare", "probar", "company", "compete"];

            string result = FindMostCommonPrefix(palabras);
            Console.WriteLine(result); // com
        }

        public string FindMostCommonPrefix(List<string> words)
        {
            if (words == null || words.Count == 0)
                return string.Empty;

            // Diccionario: prefijo -> cantidad de apariciones
            Dictionary<string, int> prefixCounts = new Dictionary<string, int>();

            foreach (var rawWord in words)
            {
                if (string.IsNullOrWhiteSpace(rawWord))
                    continue;

                string word = rawWord.Trim().ToLower();

                // Prefijos de longitud >= 2
                for (int len = 2; len <= word.Length; len++)
                {
                    string prefix = word.Substring(0, len);

                    if (prefixCounts.ContainsKey(prefix))
                        prefixCounts[prefix]++;
                    else
                        prefixCounts[prefix] = 1;
                }
            }

            string bestPrefix = string.Empty;
            int bestCount = 0;

            foreach (var kvp in prefixCounts)
            {
                string prefix = kvp.Key;
                int count = kvp.Value;

                // (Opcional) Sólo considerar prefijos que aparezcan en al menos 2 palabras
                if (count < 2)
                    continue;

                if (count > bestCount)
                {
                    bestCount = count;
                    bestPrefix = prefix;
                }
                else if (count == bestCount && prefix.Length > bestPrefix.Length)
                    bestPrefix = prefix; // mismo conteo, prefijo más largo
            }

            return bestPrefix;
        }

    }
}
