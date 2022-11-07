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
    public class ExpenseContentManager : IExpenseContentService
    {
        IExpenseContentDAL _expenseContentDAL;

        public ExpenseContentManager(IExpenseContentDAL expenseContentDAL)
        {
            _expenseContentDAL = expenseContentDAL;
        }

        public List<ExpenseContent> GetAllList()
        {
            return _expenseContentDAL.GetAll();
        }

        public List<ExpenseContent> GetAllList(Expression<Func<ExpenseContent, bool>> filter = null)
        {
            return _expenseContentDAL.GetAll(filter);
        }

        public ExpenseContent GetById(int id)
        {
            return _expenseContentDAL.GetById(id);
        }

        public void TAdd(ExpenseContent t)
        {
            _expenseContentDAL.Insert(t);
        }

        public void TRemove(ExpenseContent t)
        {
            _expenseContentDAL.Delete(t);
        }

        public void TUpdate(ExpenseContent t)
        {
            _expenseContentDAL.Update(t);
        }
    }
}
