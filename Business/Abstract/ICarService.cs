using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        Result Add(Car car);
        Result Update(Car car);
        Result Delete(Car car);
        DataResult<List<Car>> GetAll();
        DataResult<Car> GetById(int id);
        DataResult<List<Car>> GetByBrandId(int brandId);
        DataResult<List<Car>> GetByColorId(int colorId);

        DataResult<List<CarDetailDto>> GetByCarDetailDtos();
    }
}
