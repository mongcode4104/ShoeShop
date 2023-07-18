using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoeShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { get; set; }
    }
}