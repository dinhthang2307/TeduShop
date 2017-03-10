﻿using TeduShop.Model.Models;
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