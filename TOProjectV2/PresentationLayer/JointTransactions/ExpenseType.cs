using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.JointTransactions
{
    public class ExpenseType
    {
        List<string> expenseTypeList = new List<string>();
        public ExpenseType()
        {
            expenseTypeList.Add("YEMEK");
            expenseTypeList.Add("ULAŞIM");
            expenseTypeList.Add("ELEKTİRİK");
            expenseTypeList.Add("İNTERNET");
            expenseTypeList.Add("DOĞAL GAZ");
            expenseTypeList.Add("SU");
            expenseTypeList.Add("PERSONEL MAAŞI");
            expenseTypeList.Add("SİGORTA");
            expenseTypeList.Add("KİRA");
            expenseTypeList.Add("İŞLETİM GİDERLERİ");
            expenseTypeList.Add("REKLAM VE PAZARLAMA");
            expenseTypeList.Add("BAKIM VE ONARIM");
            expenseTypeList.Add("OFİS MALZEMELERİ");
            expenseTypeList.Add("AVUKAT ÜCRETLERİ");
            expenseTypeList.Add("ARAÇ GİDERLERİ");
            expenseTypeList.Add("SEYAHAT MASRAFLARI");
            expenseTypeList.Add("YAZILIM MASRAFLARI");
            expenseTypeList.Add("DANIŞMANLIK");
            expenseTypeList.Add("DİĞER");
        }
        public bool TypeControl(string TypeName)
        {
            return expenseTypeList.Contains(TypeName);
        }

        public List<string> GetAllTypeList()
        {
            return expenseTypeList.ToList();
        }
    }
}
