using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.AbstractFactory
{
    abstract class AbstractFactory
    {
        internal abstract Document CreateDocument();
        internal abstract Spreadsheet CreateSpreadsheet();


    }
}
