using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public int CategoryID { set; get; }

        public string Image { set; get; }

        public string MoreImages { set; get; }

        public decimal Price { set; get; }

        public decimal? Promotion { set; get; }

        public int? Warranty { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public string Tags { get; set; }

        public bool? HomeFlag { set; get; }

        public int Quantity { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public decimal OriginalPrice { set; get; }

        public int? viewCount { set; get; }
        public virtual ProductCategoryViewModel ProductCategory { set; get; }
       
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
    }
}