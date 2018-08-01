using Patterns.Creational.AbstractFactory;
using Patterns.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{

    class Program
    {
        static void Main(string[] args)
        {
            App app;
            //app = new AbstractFactoryApp();
            app = new BuilderApp();

            app.Run();
        }
    }
}
