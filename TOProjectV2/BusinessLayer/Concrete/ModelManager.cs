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
    public class ModelManager:IModelService
    {
        IModelDAL _modelDAL;

        public ModelManager(IModelDAL modelDAL)
        {
            _modelDAL = modelDAL;
        }

        public List<Model> GetAllList()
        {
            return _modelDAL.GetAll();
        }

        public List<Model> GetAllList(Expression<Func<Model, bool>> filter = null)
        {
            return _modelDAL.GetAll(filter);
        }

        public Model GetById(int id)
        {
            return _modelDAL.GetById(id);
        }

        public void TAdd(Model t)
        {
            _modelDAL.Insert(t);
        }

        public void TRemove(Model t)
        {
            _modelDAL.Delete(t);
        }

        public void TUpdate(Model t)
        {
            _modelDAL.Update(t);
        }
    }
}
