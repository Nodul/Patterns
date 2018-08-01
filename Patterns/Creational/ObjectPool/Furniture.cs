using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.ObjectPool
{
    /// <summary>
    /// Reusable
    /// </summary>
    class Furniture
    {
        public int Id { get; private set; }

        public Furniture(int id)
        {
            Id = id;
        }
    }
}
