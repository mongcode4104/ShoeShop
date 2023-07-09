using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key,Column(Order = 0)]
        public int ProductID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(Order = 1,TypeName ="varchar")]
        public string TagID { get; set; }
        
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
