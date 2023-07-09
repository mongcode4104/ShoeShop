using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface IPageRepository: IRepository<Page>
    {

    }
    public class PageRepository: RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
