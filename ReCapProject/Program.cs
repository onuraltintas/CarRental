using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car{Id = 6,BrandId = 4,ColorId = 3,DailyPrice = 25,ModelYear = "2011",Description = "Mazda 6 "});

            carManager.Update(new Car{Id = 6,BrandId = 4,ColorId = 1,DailyPrice = 30,ModelYear="2011",Description = "Mazda 6 Skyactive"});

            carManager.Delete(new Car{Id = 6});


            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------------------");

            Console.WriteLine(carManager.GetById(1).Data.Description);

            Console.WriteLine("-----------------------------");


        }
    }
}
