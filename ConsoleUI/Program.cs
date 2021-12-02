using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarsByColorId(6))
            {
                Console.WriteLine(car.Description);
            }

            Car _car;
            _car = new Car { BrandId = 2, ColorId = 3, ModelYear = 2015, DailyPrice = 70000, Description = "Nice car" };
            //carManager.Add(_car);
        }
    }
}
