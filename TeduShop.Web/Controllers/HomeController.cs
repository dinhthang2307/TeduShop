using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Models;

namespace TeduShop.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryService _productCategoryService;
        ICommonService _commonService;
        IProductService _producService;

        public HomeController(IProductCategoryService productCategoryService
            , ICommonService commonService, IProductService productService)
        {
            _productCategoryService = productCategoryService;
            _commonService = commonService;
            _producService = productService;
        }
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var slideModel = _commonService.GetSlides();
            var slideView = Mapper.Map<IEnumerable<Slide>, IEnumerable<SlideViewModel>>(slideModel);
            var homeViewModel = new HomeViewModel();
            homeViewModel.Slides = slideView;

            var lastestProductModel = _producService.GetLastest(3);
            var lastestProductViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(lastestProductModel);
            var topSaleProductModel = _producService.GetHotProduct(3);
            var topSaleProductViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(topSaleProductModel);
            homeViewModel.LastestProducsts = lastestProductViewModel;
            homeViewModel.TopSaleProducsts = topSaleProductViewModel;
            return View(homeViewModel);
        }

        /// <summary>
        /// About
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        /// <summary>
        /// Footer
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        /// <summary>
        /// Header
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }

        /// <summary>
        /// Category
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Category()
        {

            var model = _productCategoryService.GetAll();
            var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
            return PartialView(listProductCategoryViewModel);
        }
            
    }
}