using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface IPostTagRepository: IRepository<PostTag>
    {

    }
    public class PostTagRepository: RepositoryBase<PostTag>,IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory):
            base(dbFactory)
        {

        }
    }
}
