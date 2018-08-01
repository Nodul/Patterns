using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class BuilderApp : App
    {
        internal override void Run()
        {
            AppName = "Rifle Builder App";
            RifleBuilder builder = null;
            RifleForeman director; 

            Console.WriteLine($"Welcome to our {AppName}.");
            Thread.Sleep(500);
            Console.WriteLine("Please select your Rifle type:");
            Console.WriteLine("\n1 - Hunting \n\n2 - Laser \n\nAnything else - exit");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        builder = new HuntingRifleBuilder();
                        break;
                    case 2:
                        builder = new LaserRifleBuilder();
                        break;
                    default:
                        goto END;
                }
                director = new RifleForeman(builder);
                Rifle rifle = director.BuildRifle();

                Console.WriteLine(rifle.ToString());
            }

            END:
            Console.WriteLine($"Thank you for using our {AppName}. See you soon!");
        }
    }
}
