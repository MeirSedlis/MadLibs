using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program was built as part of an exercise 
            from Codecademy.com's Learn C# course. 

            Author: Meir Sedlis
            */


            // Let the user know that the program is starting:
            Console.WriteLine("The game is about to begin...");

            // Give the Mad Lib a title:
            string title = "All The Best Stories Have Titles Like This";

            Console.WriteLine(title);
            // Define user input and variables:

            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string firstAdjective = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            string secondAdjective = Console.ReadLine();

            Console.Write("Enter one more adjective: ");
            string thirdAdjective = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string firstNoun = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string secondNoun = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
