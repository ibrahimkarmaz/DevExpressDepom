using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.JointTransactions
{
    public class BankName
    {
        List<string> BankNameList = new List<string>();
        public BankName()
        {//TÜRKİYEDEKİ TÜM BANKALAR (2023)
            BankNameList.Add("AKBANK T.A.Ş.");
            BankNameList.Add("ALTERNATİFBANK A.Ş.");
            BankNameList.Add("ANADOLUBANK A.Ş.");
            BankNameList.Add("ARAP TÜRK BANKASI A.Ş.");
            BankNameList.Add("BANK MELLAT");
            BankNameList.Add("BANK OF CHINA TURKEY A.Ş.");
            BankNameList.Add("BURGAN BANK A.Ş.");
            BankNameList.Add("CITIBANK A.Ş.");
            BankNameList.Add("DENİZBANK A.Ş.");
            BankNameList.Add("DEUTSCHE BANK A.Ş.");
            BankNameList.Add("FİBABANKA A.Ş.");
            BankNameList.Add("HABIB BANK LIMITED");
            BankNameList.Add("HSBC BANK A.Ş.");
            BankNameList.Add("ICBC TURKEY BANK A.Ş.");
            BankNameList.Add("ING BANK A.Ş.");
            BankNameList.Add(".INTESA SANPAOLO S.P.A.");
            BankNameList.Add("JP MORGAN CHASE BANK NATIONAL ASSOCIATION");
            BankNameList.Add("MUFG BANK TURKEY A.Ş.");
            BankNameList.Add("ODEA BANK A.Ş.");
            BankNameList.Add("QNB FİNANSBANK A.Ş.");
            BankNameList.Add("RABOBANK A.Ş.");
            BankNameList.Add("SOCIETE GENERALE S.A.");
            BankNameList.Add("ŞEKERBANK T.A.Ş.");
            BankNameList.Add("T.C. ZİRAAT BANKASI A.Ş.");
            BankNameList.Add("TURKISH BANK A.Ş.");
            BankNameList.Add("TURKLAND BANK A.Ş.");
            BankNameList.Add("TÜRK EKONOMİ BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE GARANTİ BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE HALK BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE İŞ BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE VAKIFLAR BANKASI T.A.O.");
            BankNameList.Add("YAPI VE KREDİ BANKASI A.Ş.");
            BankNameList.Add("AKTİF YATIRIM BANKASI A.Ş.");
            BankNameList.Add("BANK OF AMERICA YATIRIM BANK A.Ş.");
            BankNameList.Add("D YATIRIM BANKASI A.Ş.");
            BankNameList.Add("DESTEK YATIRIM BANKASI A.Ş.");
            BankNameList.Add("DİLER YATIRIM BANKASI A.Ş.");
            BankNameList.Add("GOLDEN GLOBAL YATIRIM BANKASI A.Ş.");
            BankNameList.Add("GSD YATIRIM BANKASI A.Ş.");
            BankNameList.Add("İLLER BANKASI A.Ş.");
            BankNameList.Add("İSTANBUL TAKAS VE SAKLAMA BANKASI A.Ş.");
            BankNameList.Add("NUROL YATIRIM BANKASI A.Ş.");
            BankNameList.Add("PASHA YATIRIM BANKASI A.Ş.");
            BankNameList.Add("STANDARD CHARTERED YATIRIM BANKASI TÜRK A.Ş.");
            BankNameList.Add("TÜRKİYE İHRACAT KREDİ BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE KALKINMA VE YATIRIM BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE SINAİ KALKINMA BANKASI A.Ş.");
            BankNameList.Add("ALBARAKA TÜRK KATILIM BANKASI A.Ş.");
            BankNameList.Add("KUVEYT TÜRK KATILIM BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE EMLAK KATILIM BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE FİNANS KATILIM BANKASI A.Ş.");
            BankNameList.Add("VAKIF KATILIM BANKASI A.Ş.");
            BankNameList.Add("ZİRAAT KATILIM BANKASI A.Ş.");
            BankNameList.Add("ADABANK A.Ş.");
            BankNameList.Add("BİRLEŞİK FON BANKASI A.Ş.");
            BankNameList.Add("TÜRK TİCARET BANKASI A.Ş.");
            BankNameList.Add("TÜRKİYE EKONOMİ BANKASI");
        }
        public bool BankNameControl(string Name)
        {
            return BankNameList.Contains(Name);
        }

        public List<string> GetAllBankName()
        {
            return BankNameList.ToList();
        }
    }
}
