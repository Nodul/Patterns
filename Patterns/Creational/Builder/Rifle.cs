using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class Rifle
    {
        Stock Stock;
        RifleAction RifleAction;
        Barrel Barrel;

        public Rifle(Stock stock, RifleAction rifleAction, Barrel barrel)
        {
            Stock = stock;
            RifleAction = rifleAction;
            Barrel = barrel;
        }

        public override string ToString()
        {
            return $"This is a rifle with a {Stock.Name} stock, {RifleAction.Name} rifle action and {Barrel.Name} barrel.";
        }
    }
}
