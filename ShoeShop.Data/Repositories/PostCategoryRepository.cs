using ShoeShop.Data.Infrastructure;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data.Repositories
{
    public interface IPostCategoryRepository: IRepository<PostCategory>
    {
        IEnumerable<PostCategory> GetByAlias(string alias);
    }
    public class PostCategoryRepository: RepositoryBase<PostCategory>,IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory):
            base(dbFactory)
        {

        }

        public IEnumerable<PostCategory> GetByAlias(string alias)
        {
            return this.DbContext.PostCategories.Where(c => c.Alias == alias);
        }
    }
}
