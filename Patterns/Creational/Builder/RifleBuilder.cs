using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    abstract class RifleBuilder
    {
        Rifle Rifle { get; set; }
        public void BuildRifle()
        {
            this.Rifle = new Rifle(BuildStock(), BuildRifleAction(), BuildBarrel());
        }

        internal abstract Stock BuildStock();
        internal abstract RifleAction BuildRifleAction();
        internal abstract Barrel BuildBarrel();
    }
}
