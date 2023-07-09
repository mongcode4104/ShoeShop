using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface ISuportOnlineRepository: IRepository<SupportOnline>
    {

    }
    public class SuportOnlineRepository: RepositoryBase<SupportOnline>, ISuportOnlineRepository
    {
        public SuportOnlineRepository(DbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
