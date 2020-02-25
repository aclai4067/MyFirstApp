using System;

namespace MyFirstConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            if (userEntry == "Nathan")
            {
                Console.WriteLine("the beach cat");
            }
            else
            {
                Console.WriteLine("not a beach cat");
            }

            var i = 0;

            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of j is {j}");
            }

            foreach (var currentCharacter in userEntry)
            {   
                if (currentCharacter == 'n' || currentCharacter == 'N')
                {
                    continue;
                }
                Console.WriteLine($"the current charcter is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "Nathan":
                case "Winston":
                    Console.WriteLine("A Beach Cat");
                    break;
                default:
                    Console.WriteLine("still not a beach cat");
                    break;
            }

            var isNathan = userEntry == "Nathan" ? true : false;

            try
            {
                var x = 0;
                var y = 1 / x;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
