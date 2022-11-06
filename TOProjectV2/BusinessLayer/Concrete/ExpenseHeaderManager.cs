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
    public class ExpenseHeaderManager : IExpenseHeaderService
    {
        IExpenseHeaderDAL _expenseHeaderDAL;

        public ExpenseHeaderManager(IExpenseHeaderDAL expenseHeaderDAL)
        {
            _expenseHeaderDAL = expenseHeaderDAL;
        }

        public List<ExpenseHeader> GetAllList()
        {
            return _expenseHeaderDAL.GetAll();
        }

        public List<ExpenseHeader> GetAllList(Expression<Func<ExpenseHeader, bool>> filter = null)
        {
            return _expenseHeaderDAL.GetAll(filter);
        }

        public ExpenseHeader GetById(int id)
        {
            return _expenseHeaderDAL.GetById(id);
        }

        public void TAdd(ExpenseHeader t)
        {
            _expenseHeaderDAL.Insert(t);
        }

        public void TRemove(ExpenseHeader t)
        {
            _expenseHeaderDAL.Delete(t);
        }

        public void TUpdate(ExpenseHeader t)
        {
            _expenseHeaderDAL.Update(t);
        }
    }
}
