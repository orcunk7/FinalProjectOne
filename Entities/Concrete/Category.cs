using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategotyId { get; set; }
        public string CategoryName { get; set; }
    }
}
