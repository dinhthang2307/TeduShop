using System.Collections.Generic;
using TeduShop.Common;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.Service
{
    public interface IProductService
    {
        Product Add(Product Product);

        void Update(Product Product);

        Product Delete(int id);

        IEnumerable<Product> GetAll();
       
        IEnumerable<Product> GetAll(string keyWord);

        Product GetById(int id);

        void Save();

        IEnumerable<Product> GetLastest(int top);

        IEnumerable<Product> GetHotProduct(int top);
    }

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;
        private ITagRepository _tagRepository;
        private IProductTagRepository _productTagRepository;

        public ProductService(IProductRepository ProductRepository, IUnitOfWork unitOfWork,
             ITagRepository _tagRepository, IProductTagRepository _productTagRepository)
        {
            this._productRepository = ProductRepository;
            this._unitOfWork = unitOfWork;
            this._tagRepository = _tagRepository;
            this._productTagRepository = _productTagRepository;
        }

        public Product Add(Product Product)
        {
            //add product
            var product = _productRepository.Add(Product);
            _unitOfWork.Commit();

            //add tag
            if (!string.IsNullOrEmpty(Product.Tags))
            {
                string[] tags = Product.Tags.Split(',');
                for(var i=0; i<tags.Length; i++)
                {
                    var tagId = StringHelper.ToUnsignedString(tags[i]);
                    if (_tagRepository.Count(x => x.ID == tagId) == 0)
                    {
                        Tag tag = new Tag();
                        tag.ID = tagId;
                        tag.Name = tags[i];
                        tag.Type = CommonConstants.ProductTag;
                        _tagRepository.Add(tag);
                    }

                    ProductTag productTag = new ProductTag();
                    productTag.ProductID = Product.ID;
                    productTag.TagID = tagId;
                    _productTagRepository.Add(productTag);
                }
            }
            return product;
        }

        public Product Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAll(string keyWord)
        {

            if (!string.IsNullOrEmpty(keyWord))

                return _productRepository.GetMulti(x => x.Name.Contains(keyWord) || x.Description.Contains(keyWord));
            else
            {
                return _productRepository.GetAll();
            }
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public IEnumerable<Product> GetHotProduct(int top)
        {
            return _productRepository.GetMulti(x => x.Status).OrderByDescending(x => x.CreatedDate).Take(top);
        }

        public IEnumerable<Product> GetLastest(int top)
        {
            return _productRepository.GetMulti(x => x.Status && x.HotFlag == true).OrderByDescending(x => x.CreatedDate).Take(top);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product Product)
        {
            _productRepository.Update(Product);
        }
    }
}