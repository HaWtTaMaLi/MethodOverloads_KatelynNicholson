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


        static void Main()
        {
            //


        }

        static void RollDice()
        {
            //rolls a 6 sided die and writes to the console
        }
        static void RollDice(int sides)
        {
            //rolls a single die with a specified amount of sides(i.e a d4, d20, etc)
            //writes the result to the console
        }
        static void RollDice(int sides, int times)
        {
            //rolls a die with a specified amount of sides a specified amount of times
            //writes the result to the console 
        }
        static void RollDice(int sides, int times, ConsoleColor color = ConsoleColor.Red)
        {
            //sets the console's foreground color to a specified color (the default is red)
            //rolls a die with a specified amount of sides a specified amount of times
            //writes the result to the console
            //sets the foreground color back to white 
        }
    }
}
