using System;

namespace Deliverable_two
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for special juice. ");
            Console.WriteLine("How many people are in your group? Please, parties of 6 or lower."); 


            int partySize = int.Parse(Console.ReadLine());

            int seat = partySize;

            double admitOne = 9.99;

            double water = 0.00;

            double specialJuice = 99.99;


            Console.WriteLine("");


            Console.WriteLine("A table for " + partySize + "! Please follow me and take a seat.");
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or special juice.");

            while (seat > 0);
            {
                Console.WriteLine("Alright, person number" + seat + ", water or special juice?");
                seat--;

                
            }





        }
    }
}
