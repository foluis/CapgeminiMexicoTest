using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiMexicoCodingTest
{
    internal class AnagramChecker : IExercice
    {
        public void Run()
        {
            Console.WriteLine(IsAnagram("Listen", "Silent"));    // True
            Console.WriteLine(IsAnagram("nido", "odín"));  //False
        }

        public bool IsAnagram(string word1, string word2)
        {
            //1. Validar entradas nulas
            if (word1 == null || word2 == null)
                return false;

            // 2. Normalizar: minúsculas y quitar espacios
            string normalized1 = new string(word1.ToLower().Where(char.IsLetter).ToArray());
            string normalized2 = new string(word2.ToLower().Where(char.IsLetter).ToArray());

            // 3. Si la longitud no coincide, no pueden ser anagramas
            if (normalized1.Length != normalized2.Length)            
                return false;            

            // 4. Ordenar caracteres de cada palabra
            char[] chars1 = normalized1.OrderBy(c => c).ToArray();
            char[] chars2 = normalized2.OrderBy(c => c).ToArray();

            // 5. Comparar carácter por carácter
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])                
                    return false;                
            }

            return true;
        }
    }
}
