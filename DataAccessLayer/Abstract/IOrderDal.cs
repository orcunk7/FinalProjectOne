using Core.DataAccess;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {

    }
}
