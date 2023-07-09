using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface ISlideRepository: IRepository<Slide>
    {

    }
    public class SlideRepository: RepositoryBase<Slide>,ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
