using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Result Add(Rental rental);
        Result Update(Rental rental);  
        Result Delete(Rental rental);
        DataResult<List<Rental>> GetAll();
    }
}
