namespace CapgeminiMexicoCodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            IExercice exercice;

            //Uncomment the exercice you want to run

            //exercice = new ShortestLengthFirst();
            //exercice = new AnagramChecker();
            exercice = new PrefixFinder();

            exercice.Run();
        }
    }
}
