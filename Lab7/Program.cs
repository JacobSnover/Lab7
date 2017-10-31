using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        public static string[] names = new string[] { "AirJordan", "Cloud", "Jacob", "Link", "Samus Aran", "Commander Sheppard", "Jason Voorhes", "Michael Myers", "Bear Grylls", "Fallout 4 Character", "Kim Driscoll" };
        public static string[] food = new string[] { "Dunks", "Mana", "Sweets", "Hearts", "Energy Tanks", "Space Ice Cream", "Not Talkking", "Rubber Masks", "Whatever he finds", "RadAway", "Coffee" };
        public static string[] hometown = new string[]  {"Chicago, Illinois", "Midgar", "Merrillville-Indiana", "Hyrule" +
                     "Metroid", "Earth, America", "Lake, The Bottom of a", "Somewhere, America", "London, England", "Boston, Massachusetts", "Pointsmith, Massachusetts"};
        static void Main(string[] args)
        {
            do
            {


                int input;

                string user = UserInput();

                input = InputIntCheck(user);

                Console.Write("\n\t\t\t\tPress enter to reach exit menu.\n\n\t\tPlease type 'Food' or 'Town' to find out more about them : ");

                string secondInput = Console.ReadLine().ToLower();

                int studentFavFood = 0;

                studentFavFood = StudentInfo(input, ref secondInput);

                Console.WriteLine(Continue());

                

            } while (true);


        }

        private static int InputIntCheck(string user)
        {
            int input;
            if (int.TryParse(user, out input))
            {
                Console.WriteLine($"\t\t\tThe student you are asking about is {names[input - 1]}");
            }

            return input;
        }

        private static int StudentInfo(int input, ref string secondInput)
        {
            int studentFavFood;
            while (true)
            {
                if (int.TryParse(secondInput, out studentFavFood))
                {
                    Console.WriteLine("\t\t\t\tThat is a wrong input. ");
                    Console.Write("\n\t\t\t\tPress enter to reach exit menu.\n\n\t\tPlease type 'Food' or 'Town' to find out more about them : ");
                    secondInput = Console.ReadLine().ToLower();
                }
                else if (secondInput == "food")
                {
                    for (int i = 0; i < food.Length; i++)
                    {
                        if (input == i)
                        {
                            Console.WriteLine($"\t\t\tThe students faorite food is: {food[i - 1]} ");
                            Console.Write("\n\t\t\t\tPress enter to reach exit menu.\n\n\t\tPlease type 'Food' or 'Town' to find out more about them : ");
                            secondInput = Console.ReadLine();
                            break;
                        }
                    }
                }
                else if (secondInput == "town")
                {
                    for (int i = 0; i < hometown.Length; i++)
                    {
                        if (input == i)
                        {
                            Console.WriteLine($"\t\t\tThe students faorite food is: {hometown[i - 1]} ");
                            Console.Write("\n\t\t\t\tPress enter to reach exit menu.\n\n\t\tPlease type 'Food' or 'Town' to find out more about them : ");
                            secondInput = Console.ReadLine();
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return studentFavFood;
        }

        private static string UserInput()
        {
            Console.Write($"\tWelcome to My Class. Enter a number from 1-11 to find out about a student : ");
            string user = Console.ReadLine();
            return user;
        }

        public static string Continue()
        {
            while (true)
            {
                Console.Write("\t\t\tDo you want to look up another student? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return ("\t\t\t\tSounds Good. ");
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine("\t\t\t\t\t\tBye");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            }
        }
    }
}
