using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, BaaContext>, IUserDal
    {
    }
}
