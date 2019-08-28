using System;

namespace MadLibsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* MadLibs Game is inputing a bunch of words and take all the random words and insert them into a story  */

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a Plural Noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter your favorite Celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
