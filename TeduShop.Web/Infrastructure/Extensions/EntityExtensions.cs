using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryvm)
        {
            postCategory.ID = postCategoryvm.ID;
            postCategory.Name = postCategoryvm.Name;

            postCategory.Description = postCategoryvm.Description;
            postCategory.Alias = postCategoryvm.Alias;
            postCategory.ParentID = postCategoryvm.ParentID;
            postCategory.DisplayOrder = postCategoryvm.DisplayOrder;

            postCategory.Image = postCategoryvm.Image;

            postCategory.HomeFlag = postCategoryvm.HomeFlag;

            postCategory.CreatedDate = postCategoryvm.CreatedDate;
            postCategory.CreatedBy = postCategoryvm.CreatedBy;
            postCategory.UpdatedDate = postCategoryvm.UpdatedDate;
            postCategory.UpdatedBy = postCategoryvm.UpdatedBy;

            postCategory.MetaDescription = postCategoryvm.MetaKeyword;

            postCategory.MetaKeyword = postCategoryvm.MetaKeyword;

            postCategory.Status = postCategoryvm.Status;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory,
            ProductCategoryViewModel productCategoryvm)
        {/*  public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        public string Description { set; get; }
        public int? ParentID { set; get; }
        public string Image { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<PostViewModel> Posts { set; get; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }

        [Required]
        public bool Status { get; set; }
*/
            productCategory.ID = productCategoryvm.ID;
            productCategory.Name = productCategoryvm.Name;

            productCategory.Description = productCategoryvm.Description;
            productCategory.Alias = productCategoryvm.Alias;
            productCategory.ParentID = productCategoryvm.ParentID;
            productCategory.DisplayOrder = productCategoryvm.DisplayOrder;

            productCategory.Image = productCategoryvm.Image;
            productCategory.HomeFlag = productCategoryvm.HomeFlag;
            productCategory.CreatedDate = productCategoryvm.CreatedDate;
            productCategory.CreatedBy = productCategoryvm.CreatedBy;
            productCategory.UpdatedDate = productCategoryvm.UpdatedDate;
            productCategory.UpdatedBy = productCategoryvm.UpdatedBy;

            productCategory.MetaDescription = productCategoryvm.MetaDescription;
            productCategory.MetaKeyword = productCategoryvm.MetaKeyword;
            productCategory.Status = productCategoryvm.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postvm)
        {
            post.ID = postvm.ID;
            post.Name = postvm.Name;
            post.Description = postvm.Description;
            post.Alias = postvm.Alias;
            post.CategoryID = postvm.CategoryID;
            post.Content = postvm.Content;
            post.HomeFlag = postvm.HomeFlag;
            post.viewCount = postvm.viewCount;

            post.CreatedDate= postvm.CreatedDate;
            post.CreatedBy = postvm.CreatedBy;
            post.UpdatedBy = postvm.UpdatedBy;
            post.UpdatedDate = postvm.UpdatedDate;
            post.MetaKeyword= postvm.MetaKeyword;
            post.MetaDescription = postvm.MetaDescription;
            post.Status = postvm.Status;
        }
    }
}