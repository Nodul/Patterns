using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.AbstractFactory
{
    class MacFactory : AbstractFactory
    {
        internal override Document CreateDocument()
        {
            return new PagesDocument();
        }

        internal override Spreadsheet CreateSpreadsheet()
        {
            return new NumbersSpreadsheet();
        }
    }
}
