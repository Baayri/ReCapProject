using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Nice car"},
                new Car {Id=2,BrandId=3,ColorId=3,ModelYear=1998,DailyPrice=300,Description="Nice car"},
                new Car {Id=3,BrandId=5,ColorId=3,ModelYear=2015,DailyPrice=700,Description="Nice car"},
                new Car {Id=4,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=1000,Description="Nice car"},
                new Car {Id=5,BrandId=4,ColorId=5,ModelYear=2021,DailyPrice=1300,Description="Nice car"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
