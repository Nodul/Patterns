using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class HuntingRifleBuilder : RifleBuilder
    {
        internal override Barrel BuildBarrel()
        {
            return new Barrel("iron");
        }

        internal override RifleAction BuildRifleAction()
        {
            return new RifleAction("break");
        }

        internal override Stock BuildStock()
        {
            return new Stock("wooden");
        }
    }
}
