using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

        public static string[] categories = new string[] { "comedy", "drama", "action", "horror", "family", "romance" };
    }

    class Validator
    {
        public static int CheckNum(string inputString, string errorMessage)
        {
            int input;
            while (!(int.TryParse(inputString, out input)) || int.Parse(inputString) <= 0 || int.Parse(inputString) > 6)
            {
                Console.WriteLine($"Im sorry, that's not a valid input. {errorMessage}");
                inputString = Console.ReadLine();
            }
            return input - 1;
        }
    }
}
