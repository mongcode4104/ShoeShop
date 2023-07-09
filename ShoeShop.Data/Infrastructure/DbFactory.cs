using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Infrastructure
{
     public class DbFactory: Disposable, IDbFactory
    {
        ShoeShopDbContext dbContext;
        public ShoeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShoeShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
