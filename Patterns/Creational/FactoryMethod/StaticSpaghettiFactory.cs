using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    public class StaticSpaghettiFactory
    {
        public static Spaghetti MakeSpaghetti(bool doYouLikeMeat)
        {
            if (doYouLikeMeat)
            {
                return new BologneseSpaghetti();
            }
            else
            {
                return new NapoliSpaghetti();
            }
        }
    }
}
