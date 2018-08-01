using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.ObjectPool
{
    class FurniturePool
    {
        private List<Furniture> freeFurniture;
        private List<Furniture> inUseFurniture;
        public int Amount { get; private set; }
        public int FreeAmount { get { return freeFurniture.Count; } }
        public int InUseAmount  { get { return inUseFurniture.Count; } }

        public FurniturePool()
        {
            freeFurniture = new List<Furniture>();
            for (int i = 0; i < 6; i++)
            {
                freeFurniture.Add(new Furniture(i));
                Amount = i;
            }
            inUseFurniture = new List<Furniture>();
        }

        public Furniture GetInstance()
        {
            // TODO there should obviouly be a lock mechanism here, so different thread won't fight over the Furniture instance
            // but this is just an GoF exercise, so I won't do this (this time).
            if (freeFurniture.Count > 0)
            {
                Furniture f = freeFurniture[0];
                freeFurniture.RemoveAt(0);
                inUseFurniture.Add(f);
                return f;
            }
            else
            {
                Amount++;
                Furniture f = new Furniture(Amount);
                inUseFurniture.Add(f);
                return f;
            }
        }

        public void ReturnFurniture(Furniture f)
        {
            if(f != null)
            {
                inUseFurniture.Remove(f);
                freeFurniture.Add(f);
            }
        }
    }
}
