using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("GÜnlük fiyat 0 dan büyük olmalı");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi", car);
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car Updated");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(car => car.ColorId == colorId);
        }

        public List<CarDetailDto> GetByCarDetailDtos()
        {
            return _carDal.GetCarDetails();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(car => car.Id == id);
        }
    }
}
