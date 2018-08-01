using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Creational.AbstractFactory
{
    class AbstractFactoryApp : IRun
    {
        private AbstractFactory factory;
        public void Run()
        {
            Console.WriteLine("Welcome to our Automated Document Factory.");
            Thread.Sleep(500);
            Console.WriteLine("Please select your System:");
            Console.WriteLine("\n1 - Windows \n\n2 - Mac \n\nAnything else - exit");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        factory = new WinFactory();
                        break;
                    case 2:
                        factory = new MacFactory();
                        break;
                }
                Document doc = factory.CreateDocument();
                Spreadsheet spr = factory.CreateSpreadsheet();
                Console.WriteLine($"Here is your new Document: {doc}");
                Console.WriteLine($"Here is your new Spreadsheet {spr}");
            }
            Console.WriteLine("Thank you for using our Automated Document Factory. See you soon!");
        }
    }
}
