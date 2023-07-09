using System;
using System.Collections.Generic;

namespace ShoeShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Alias { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public string Desription { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { get; set; }
        public virtual PostCategoryViewModel Category { get; set; }
        public IEnumerable<PostTagViewModel> PostTags { get; set; }
    }
}