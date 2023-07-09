using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface ITagRepository: IRepository<Tag>
    {

    }
    public class TagRepository: RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
