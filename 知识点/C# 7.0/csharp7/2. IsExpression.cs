using static System.Console;

namespace csharp7
{
    public class Animal
    {
        public string Name { get; set; }
    }

    public class Hamster : Animal
    {
        public int TeethLength { get; set; }
    }

    public class Bunny : Animal
    {
        public int EarLength { get; set; }
    }

    public static class IsExpression
    {
        public static void Old(Animal animal)
        {
            if (animal is Hamster)
            {
                var hamster = animal as Hamster;
                WriteLine(hamster.TeethLength);
            }
            else if (animal is Bunny)
            {
                var bunny = (Bunny)animal;
                WriteLine(bunny.EarLength);
            }
        }

        public static void New(Animal animal)
        {
            if (animal is Hamster hamster)
            {
                WriteLine(hamster.TeethLength);
            }
            else if (animal is Bunny bunny)
            {
                WriteLine(bunny.EarLength);
            }
        }
    }
}
