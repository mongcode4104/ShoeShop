using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface IVisitorStatisticRepository: IRepository<VisitorStatistic>
    {

    }
    public class VisitorStatisticRepository: RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(DbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
