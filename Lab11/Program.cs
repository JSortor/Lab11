using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            Console.WriteLine("Hello, and welcome to the amazing movie list application!");


            ArrayList movieList = new ArrayList();

            Movie talladegaNights = new Movie("Talladega Nights", "comedy");
            Movie sevenPounds = new Movie("Seven Pounds", "drama");
            Movie halloween = new Movie("Halloween", "horror");
            Movie theIncredibles = new Movie("The Incredibles", "family");
            Movie saw = new Movie("Saw", "horror");
            Movie theNotebook = new Movie("The Notebook", "romance");
            Movie outtaCompton = new Movie("Straight Outta Compton", "drama");
            Movie stepBrothers = new Movie("Step Brothers", "comedy");
            Movie gremlins = new Movie("Gremlins", "horror");
            Movie deadPool = new Movie("Deadpool", "action");

            movieList.Add(talladegaNights);
            movieList.Add(sevenPounds);
            movieList.Add(halloween);
            movieList.Add(theIncredibles);
            movieList.Add(saw);
            movieList.Add(theNotebook);
            movieList.Add(outtaCompton);
            movieList.Add(stepBrothers);
            movieList.Add(gremlins);
            movieList.Add(deadPool);


            while (runP)
            {
                PrintCategories();

                Console.WriteLine("Enter the number of the genre you are looking for: ");
                int inputNum = Validator.CheckNum(Console.ReadLine(), "\nPlease enter a number between 1-6: ");

                PrintList(inputNum, movieList);

                runP = KeepRunning("Would you like to continue? (y/n) ");
            }
        }

        static void PrintCategories()
        {
            for (int i = 0; i < Movie.categories.Length; i++)
            {
                Console.WriteLine($"{i + 1} -- {Movie.categories[i]}");
            }
        }

        static void PrintList(int numCategory, ArrayList movieList)
        {
            Console.WriteLine($"\nYou chose {numCategory + 1} -- {Movie.categories[numCategory]}.\n");

            ArrayList newList = new ArrayList();

            foreach(Movie m in movieList)
            {
                if (m.Category == Movie.categories[numCategory])
                { 
                    newList.Add(m.Title);
                }
            }
            newList.Sort();
            Console.WriteLine($"There are {newList.Count} films in this library considered {Movie.categories[numCategory]}:\n");

            foreach (var n in newList)
            {
                Console.WriteLine(n);
            }
        }

        static bool KeepRunning(string message)
        {
            bool correctInput = true;
            bool continuer = true;
            do
            {
                Console.WriteLine("\n" + message);

                string confirm = Console.ReadLine().ToLower();
                if (confirm == "n" || confirm == "no")
                {
                    Console.WriteLine("\nGoodbye, come back soon!");
                    continuer = false;
                    correctInput = true;
                    Console.ReadKey();
                }
                else if (confirm == "y" || confirm == "yes")
                {
                    Console.WriteLine("\nSounds Good!\n");
                    continuer = true;
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't understand.");
                }
            } while (!correctInput);
            return continuer;
            
        }
    }
}
