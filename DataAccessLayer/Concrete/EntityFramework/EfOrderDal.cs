using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthWindContext>, IOrderDal
    {
    }
}
