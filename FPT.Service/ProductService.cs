using FPT.Data.Infrastructure;
using FPT.Data.Repositories;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product Add(Product entity);
        void Update(Product entity);
        void Delete(int id);

        void Save();
        
    }
    public class ProductService : IProductService
    {
        
        private IProductRepository _productRepository;
        private IUnitOfWork _uow;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._uow = unitOfWork;
        }
        public Product Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Save()
        {
            _productRepository.Save();
        }
    }
}
