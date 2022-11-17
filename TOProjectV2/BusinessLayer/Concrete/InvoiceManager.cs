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
    public class InvoiceManager : IInvoiceService
    {/*BURADA DÜZENLEME YAPILACAK.*/
        IInvoiceDAL _invoiceDAL;

        public InvoiceManager(IInvoiceDAL invoiceDAL)
        {
            _invoiceDAL = invoiceDAL;
        }

        public List<Invoice> GetAllList()
        {
            return _invoiceDAL.GetAll();
        }

        public List<Invoice> GetAllList(Expression<Func<Invoice, bool>> filter = null)
        {
            return _invoiceDAL.GetAll(filter);
        }

        public Invoice GetById(int id)
        {
            return _invoiceDAL.GetById(id);
        }

        public void TAdd(Invoice t)
        {
            _invoiceDAL.Insert(t);
        }

        public void TRemove(Invoice t)
        {
            _invoiceDAL.Delete(t);
        }

        public void TUpdate(Invoice t)
        {
            _invoiceDAL.Update(t);
        }
    }
}
