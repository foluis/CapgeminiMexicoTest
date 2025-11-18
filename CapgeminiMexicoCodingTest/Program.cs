namespace CapgeminiMexicoCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            IExercice exercice;
                        
            //exercice = new ShortestLengthFirst();
            exercice = new AnagramChecker();

            exercice.Run();
        }
    }
}
