using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    class NapoliSpaghettiFactory : SpaghettiFactory
    {
        public override Spaghetti MakeSpaghetti()
        {
            return new NapoliSpaghetti();
        }
    }
}
