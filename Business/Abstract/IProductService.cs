using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllById();
        List<Product> GetAllById(int id);
        List<Product> GetAllByUnitPrice(decimal min,decimal max);
    }
}
