using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    class FactoryMethodApp : App
    {
        internal override void Run()
        {
            AppName = "Spaghetti Factory";
            SpaghettiFactory factory;
            Spaghetti spaghetti = null;
        
            Console.WriteLine($"Welcome to our {AppName}.");
            Thread.Sleep(500);
            Console.WriteLine("Please select your Spagetthi type:");
            Console.WriteLine("\n1 - Bolognese \n\n2 - Napoli \n\nAnything else - exit");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        factory = new BologneseSpaghettiFactory();
                        break;
                    case 2:
                        factory = new NapoliSpaghettiFactory();
                        break;
                    default:
                        goto END;
                }
                spaghetti = factory.MakeSpaghetti();

                Console.WriteLine(spaghetti);
            }
            END:
            spaghetti = null;
            Thread.Sleep(500);
            Console.WriteLine("Bonus question: Do you like meat? :");
            Console.WriteLine("\n1 - Yes \n\n2 - No \n\nAnything else - exit");
            input = Console.ReadLine();
            if(input == "yes" || input == "y")
            {
                spaghetti = StaticSpaghettiFactory.MakeSpaghetti(true);
            }
            else if (input == "no" || input == "n")
            {
                spaghetti = StaticSpaghettiFactory.MakeSpaghetti(false);
            }
            Console.WriteLine($"Extra round of Spaghetti: {spaghetti}");

            Console.WriteLine($"Thank you for using our {AppName}. See you soon!");
        }
    }
}
