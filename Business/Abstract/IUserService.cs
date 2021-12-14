using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Result Add(User user);
        Result Update(User user);
        Result Delete(User user);
        DataResult<List<User>> GetAll();
    }
}
