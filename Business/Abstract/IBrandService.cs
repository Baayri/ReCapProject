using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Result Add(Brand brand);
        Result Update(Brand brand);
        Result Delete(Brand brand);
        DataResult<List<Brand>> GetAll();
        DataResult<Brand> GetById(int id);
    }
}
