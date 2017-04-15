using FPT.Data.Infrastructure;
using FPT.Model.Models;
using FPT.Service;
using FTP.Web.Security;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FTP.Web.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/product")]
    [CustomAuthorize]
    public class ProductController : ApiController
    {
        private IProductService _productService;
        private IUnitOfWork _unitOfWork;

        public ProductController(IProductService productService, IUnitOfWork unitOfWork)
        {
            this._productService = productService;
            this._unitOfWork = unitOfWork;
            
        }

        [Route("getall")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _productService.GetAll());
        }

        [Route("getbyid/{Id}")]
        public HttpResponseMessage GetById(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _productService.GetById(Id));
        }

        [Route("add")]
        public HttpResponseMessage Add(Product model)
        {
            var product = _productService.Add(model);
            _productService.Save();
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        [HttpPut]
        [Route("update")]
        public void Update(Product model)
        {
            var product = _productService.GetById(model.Id);
            product.Name = model.Name;
            product.Price = model.Price;
            product.Description = model.Description;
            _productService.Update(product);
            _productService.Save();
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public void Delete(int Id)
        {
            _productService.Delete(Id);
            _productService.Save();
        }
    }
}
