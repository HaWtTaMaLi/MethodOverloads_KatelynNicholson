using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloads_KatelynNicholson
{
    internal class Program
    {
        //
        static Random random = new Random();
        

        static void Main()
        {
            //Roll a 6Die 3 times
            RollDice();
            Console.ReadKey();
            RollDice();
            Console.ReadKey();
            RollDice();
            Console.ReadKey();

            //roll a different Die 3 times
            RollDice(20);
            Console.ReadKey();
            RollDice(4);
            Console.ReadKey();
            RollDice(100);
            Console.ReadKey();

            //roll a different die 3 times 4 times 5 times
            RollDice(20, 3);
            Console.ReadKey();
            RollDice(4, 4);
            Console.ReadKey();
            RollDice(100, 5);
            Console.ReadKey();

            //Roll a different die differet times in Color
            RollDice(20, 3, color:ConsoleColor.Red);
            Console.ReadKey();
            RollDice(4, 4, color: ConsoleColor.Blue);
            Console.ReadKey();
            RollDice(100, 5, color: ConsoleColor.Yellow);
            Console.ReadKey();

            //Show the console is back to normal color
            RollDice(20, 3, color: ConsoleColor.Red);
            Console.ReadKey();
            RollDice();
            Console.ReadKey();
            RollDice(20);
            Console.ReadKey();
            RollDice(100, 5, color: ConsoleColor.Yellow);
            Console.ReadKey();
            RollDice(100, 5);
            Console.ReadKey();


        }

        static void RollDice()
        {
            //rolls a 6 sided die and writes to the console
                
                int randomNumber = random.Next(1, 7); //Min&Max
                Console.WriteLine($"You rolled a 6 Sided Die and got: " + (randomNumber));
        }
        static void RollDice(int sides)
        {
            //rolls a single die with a specified amount of sides(i.e a d4, d20, etc)
            //writes the result to the consolew
            //sides = 20;
            int randomNumber = random.Next(1, sides +1);
            Console.WriteLine($"You rolled a {sides} Sided Die and got: {randomNumber}");
        }
        static void RollDice(int sides, int times)
        {
            //rolls a die with a specified amount of sides a specified amount of times
            //writes the result to the console 
            for (int i = 0; i < times; i++)
            {
                int randomNumber = random.Next(1, sides);
                Console.WriteLine($"You rolled a {sides} Sided Die {times} times and got: {randomNumber}");
            }

        }

        // string myName = "Simon";
        // if(myName == "Simon")

        // myAge = 100
        // if(myAge < 50) // i dont get the cheap movie ticket 


        static void RollDice(int sides, int times, ConsoleColor color = ConsoleColor.Red)
        {
            //sets the console's foreground color to a specified color (the default is red)
            //rolls a die with a specified amount of sides a specified amount of times
            //writes the result to the console
            //sets the foreground color back to white
            Console.ForegroundColor = color;
            for (int i = 0; i < times; i++)
            {
                int randomNumber = random.Next(1, sides + 1);
                Console.WriteLine($"You rolled a {sides} Sided Die {times} times and got: {randomNumber}");
            }

            Console.ResetColor();
        }
    }
}
