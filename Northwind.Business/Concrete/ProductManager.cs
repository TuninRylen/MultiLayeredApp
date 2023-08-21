using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntitiyFramework;
using Northwind.Entities.Concrete;
using Northwind.entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager (IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validater(new ProductValidater(), product);

            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException)
            {
                throw new Exception("Güncelleme Gerçekleşemedi");
            }
            
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=> p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
