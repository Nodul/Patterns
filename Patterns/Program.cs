using Patterns.Creational.AbstractFactory;
using Patterns.Creational.Builder;
using Patterns.Creational.FactoryMethod;
using Patterns.Creational.ObjectPool;

namespace Patterns
{

    class Program
    {
        static void Main(string[] args)
        {
            App app;
            //app = new AbstractFactoryApp();
            //app = new BuilderApp();
            //app = new FactoryMethodApp();
            app = new ObjectPoolApp();
            app.Run();
        }
    }
}
