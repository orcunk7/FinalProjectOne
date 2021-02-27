using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityMemory
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContext>, IProductDal
    {

    }
}
