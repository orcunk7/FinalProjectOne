using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"\Server = 175.45.2.12");/* 1.30  */

            //https://www.youtube.com/watch?v=ow-EHetuNAU&feature=emb_logo&ab_channel=EnginDemiro%C4%9F
        }
    }
}
