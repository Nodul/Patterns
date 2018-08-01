using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Creational.ObjectPool
{
    class ObjectPoolApp : App
    {
        private readonly FurniturePool pool = new FurniturePool();
        internal override void Run()
        {
            AppName = "Object Pool";
            Console.WriteLine($"Welcome to our {AppName}.");
            Thread.Sleep(500);
            List<Furniture> myFurniture = new List<Furniture>();
            Furniture f;
            for(int i = 0; i < pool.Amount; i++)
            {
                f = pool.GetInstance();
                Console.WriteLine($"Fetched Furniture with id {f.Id}");
                myFurniture.Add(f);
            }
            Console.WriteLine($"Reached pool capacity of {pool.Amount}");
            Console.WriteLine("Calling GetInstance one more time, at max amount.");
            f = pool.GetInstance();
            myFurniture.Add(f);               
            Console.WriteLine($"Since the pool has overflown, the new id should be 5:");
            Console.WriteLine($"Id of newest furniture: {f.Id}");
            Console.WriteLine("Now lets test recycling!");
            for(int i = myFurniture.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Giving back furniture with id = {myFurniture[i].Id}");
                pool.ReturnFurniture(myFurniture[i]);
                myFurniture.Remove(myFurniture[i]);
            }
            Console.WriteLine($"Currently we have no more furniture. Our furniture count: {myFurniture.Count}");
            Console.WriteLine($"Furniture pool's object count should be the same as in beginning (5) : {pool.FreeAmount}");
            Console.WriteLine("Since the pool is restored, let's test adding NEW objects to the pool");
            for(int i = 0; i <= 9; i++) 
            {
                f = pool.GetInstance();
                Console.WriteLine($"Fetched furniture with id = {f.Id}");
                myFurniture.Add(f);
            }
            Console.WriteLine($"Since we created a few more Furniture objects, then our Furniture store should equal he pool's amount");            Console.WriteLine($"The pool's free amount should equal 0 and is equal to: {pool.FreeAmount}");
            Console.WriteLine($"And the pool's in use Amount should equal our Furniture count {myFurniture.Count} =? {pool.InUseAmount}");

            Console.WriteLine($"Thank you for using our {AppName}. See you soon!");
        }
    }
}
