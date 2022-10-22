using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class BlandValidator:AbstractValidator<Bland>
    {
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        public BlandValidator(string blandName)
        {
            RuleFor(x=>x.BlandName).NotEmpty().WithMessage("MARKA ADI BOŞ BIRAKILAMAZ.");
            RuleFor(y => y.BlandName).MinimumLength(2).WithMessage("MARKA ADI EN AZ 2 KARAKTER İÇERMELİ.");
            RuleFor(z => z.BlandName).MaximumLength(20).WithMessage("MARKA ADI EN FAZLA 20 KARAKTER OLMALI.");
            if (_blandManager.GetByBlandName(x => x.BlandName.ToLower() == blandName.ToLower() && x.BlandArchive==false))//BOOL DEĞERİ TRUE GELDİĞİNDE 
            {//BLANDNAME EŞİT OLDUĞU İÇİN blandName değeri verildi.
                RuleFor(w => w.BlandName).NotEqual(blandName)
                    .WithMessage("MARKA ADI SİSTEMDE KAYITLIDIR.\nKAYIT ARŞİVDEDİR. ÇIKARMAK İÇİN ARŞİV BÖLÜMÜNÜ KONTROL EDİNİZ.");
            }
            else if (_blandManager.GetByBlandName(x => x.BlandName.ToLower() == blandName.ToLower() && x.BlandArchive == true))//EĞER ARŞİVDE DEĞİL NORMAL OLARAK AKTİF VE TRUE İSE;
            {//BURADA AKTİF OLAN TÜRÜN BİLGİSİ VERİLDİ.
                RuleFor(w => w.BlandName).NotEqual(blandName)
                  .WithMessage("MARKA ADI SİSTEMDE KAYITLIDIR.");
            }
        }
    }
}
