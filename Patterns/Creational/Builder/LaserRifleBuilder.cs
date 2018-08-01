using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class LaserRifleBuilder : RifleBuilder
    {
        internal override Barrel BuildBarrel()
        {
            return new Barrel("duranium"); 
        }

        internal override RifleAction BuildRifleAction()
        {
            return new RifleAction("laser");
        }

        internal override Stock BuildStock()
        {
            return new Stock("titanium");
        }
    }
}
