﻿using Northwind.Entities.Concrete;
using Northwind.entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void Update(Product product);
    }
}
