using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var x in carManager.GetAll())
            {
                Console.WriteLine(x.Description);
            }
            
        }
    }
}
