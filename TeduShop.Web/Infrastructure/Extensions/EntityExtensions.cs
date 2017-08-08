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
        {
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

        public static void UpdateProduct(this Product product,
          ProductViewModel productVm)
        {
            product.ID = productVm.ID;
            product.Name = productVm.Name;

            product.Description = productVm.Description;
            product.Alias = productVm.Alias;
            product.CategoryID = productVm.CategoryID;
            product.Price = productVm.Price;
            product.MoreImages = productVm.MoreImages;
            product.Promotion = productVm.Promotion;
            product.Warranty = productVm.Warranty;
            product.HotFlag = productVm.HotFlag;
            product.ViewCount = productVm.ViewCount;

            product.HomeFlag = productVm.HomeFlag;
            product.CreatedDate = productVm.CreatedDate;
            product.CreatedBy = productVm.CreatedBy;
            product.UpdatedDate = productVm.UpdatedDate;
            product.UpdatedBy = productVm.UpdatedBy;

            product.MetaDescription = productVm.MetaDescription;
            product.MetaKeyword = productVm.MetaKeyword;
            product.Status = productVm.Status;
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