using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShop.Data.Repositories;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentID(int parentId);
        PostCategory GetById(int id);

    }
    class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCateoryRepository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCateoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postCateoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCateoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCateoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentId)
        {
            return _postCateoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCateoryRepository.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCateoryRepository.Update(postCategory);
        }
    }
}
