using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    class BologneseSpaghettiFactory : SpaghettiFactory
    {
        public override Spaghetti MakeSpaghetti()
        {
            return new BologneseSpaghetti();
        }
    }
}
