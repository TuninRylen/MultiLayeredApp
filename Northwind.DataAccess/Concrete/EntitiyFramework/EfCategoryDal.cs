using Northwind.DataAccess.Abstract;
using Northwind.entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntitiyFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
