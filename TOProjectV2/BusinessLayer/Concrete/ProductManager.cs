using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetAllList()
        {
            return _productDAL.GetAll();
        }

        public List<Product> GetAllList(Expression<Func<Product, bool>> filter = null)
        {
            return _productDAL.GetAll(filter);
        }

        public Product GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public void TAdd(Product t)
        {
            _productDAL.Insert(t);
        }

        public void TRemove(Product t)
        {
            _productDAL.Delete(t);
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
