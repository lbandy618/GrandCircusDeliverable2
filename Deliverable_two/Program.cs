using System;

namespace Deliverable_two
{
    internal class Program
    {
        static void Main(string[] args)
          {
            // Server greeting
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for special juice. ");
            Console.WriteLine("How many people are in your group? Please, parties of 6 or lower."); 
            int partySize = int.Parse(Console.ReadLine());

            if (partySize <= 6)
            {
                int seat = 1;
                int numberOfWaters = 0;
                int numberOfSpecialJuice = 0;
                double admitOne = 9.99;
                double water = 0.00;
                double specialJuice = 99.99;
                string drinkChoice; 


                Console.WriteLine();
                Console.WriteLine("A table for " + partySize + "! Please follow me and take a seat.");
                Console.WriteLine("Let's get everyone started with some drinks. We've got water or special juice.");
                Console.WriteLine();

                while (seat <= partySize)
                {
                    Console.WriteLine("Alright, person number " + seat + ", water or special juice?");
                    seat++;
                    drinkChoice = Console.ReadLine();
                    if (drinkChoice == "water")
                    {
                        Console.WriteLine("You ordered water, that's free");
                        numberOfWaters++;
                    }
                    else
                    {
                        if (drinkChoice == "special juice")
                        {
                            Console.WriteLine("You ordered special juice, that's 99.99");
                            numberOfSpecialJuice++; 
                        }
                        else
                        {
                            Console.WriteLine("We don't have that. No drink for you!");
                        }
                    }
                }
                
                double totalBill = (partySize * admitOne) + (numberOfWaters * water) + (numberOfSpecialJuice * specialJuice);

                Console.WriteLine("Okay, so that's " + numberOfWaters + " waters and " + numberOfSpecialJuice + " special juices. I'll be right back. Feel free to grab your food!");
                Console.WriteLine("Here's your bill! Total price: $" + totalBill);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
            }

        }   
    }
}
