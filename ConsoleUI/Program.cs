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
            //CarTest();
            //ColorTest();
            //BrandTest();
            //UserTest();
            CustomerTest();
            //RentalTest();
        }

        private static void BrandTest()
        {
            Console.WriteLine("************************Brand*******************************");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("********GetByID(Brand)***********");

            Brand brand1 = brandManager.GetById(2).Data;
            Console.WriteLine(brand1.Id + " " + brand1.Name);
        }

        private static void ColorTest()
        {
            Console.WriteLine("*************************Color******************************");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("********GetByID(Color)***********");

            Color color1= colorManager.GetById(4).Data;
            Console.WriteLine(color1.Id + " " + color1.Name);
        }

        private static void CarTest()
        {
            Console.WriteLine("*************************Car******************************");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByCarDetailDtos().Data)
            {
                Console.WriteLine(car.Id + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice );
            }

            Console.WriteLine("********GetByID(Car)***********");

            Car car1 = carManager.GetById(3).Data;
            Console.WriteLine(car1.Id + " " + car1.DailyPrice);


            Car _car;
            _car = new Car {Id=6, BrandId = 2, ColorId = 3, ModelYear = 2015, DailyPrice = 70000, Description = "Nice car" };
            //carManager.Delete(_car);
        }

        private static void UserTest()
        {
            Console.WriteLine("*************************User******************************");
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CustomerTest()
        {
            Console.WriteLine("*************************Customer******************************");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var item in customerManager.GetAll().Data)
            {
                Console.WriteLine(item.CompanyName);
            }

            Customer customer = new Customer { UserId = 3, CompanyName = "Company3"};

            //var result = customerManager.Add(customer);
            //Console.WriteLine(result.Message);
            
        }

        private static void RentalTest()
        {
            Console.WriteLine("*************************Rental******************************");

        }
    }
}
