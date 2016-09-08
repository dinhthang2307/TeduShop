using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;


namespace TeduShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _PostCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._PostCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory = _PostCategoryService.GetAll();

                    response = request.CreateResponse(HttpStatusCode.Created, listCategory);
                }
                return response;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _PostCategoryService.Add(postCategory);
                    _PostCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _PostCategoryService.Update(postCategory);
                    _PostCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _PostCategoryService.Delete(id);
                    _PostCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}