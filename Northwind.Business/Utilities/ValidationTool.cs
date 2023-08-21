using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validater(IValidator validator, object entity)
        {
            var result = validator.Validate((IValidationContext)entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors[1].ToString());
            }
        }
    }
}
