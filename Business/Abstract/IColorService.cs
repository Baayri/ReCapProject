using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        Result Add(Color color);
        Result Update(Color color);
        Result Delete(Color color);
        DataResult<List<Color>> GetAll();
        DataResult<Color> GetById(int id);
        
    }
}
