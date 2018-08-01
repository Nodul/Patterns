using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.AbstractFactory
{
    class WinFactory : AbstractFactory
    {
        internal override Document CreateDocument()
        {
            return new WordDocument();
        }

        internal override Spreadsheet CreateSpreadsheet()
        {
            return new ExcelSpreadsheet();
        }
    }
}
