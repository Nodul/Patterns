using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class RifleForeman
    {
        RifleBuilder builder;
        Rifle rifle;

        public RifleForeman(RifleBuilder RifleBuilder)
        {
            builder = RifleBuilder;
        }

        public Rifle BuildRifle()
        {
            return rifle = new Rifle(builder.BuildStock(), builder.BuildRifleAction(), builder.BuildBarrel());
        }
    }
}
