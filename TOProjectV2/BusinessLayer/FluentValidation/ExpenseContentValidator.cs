using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ExpenseContentValidator:AbstractValidator<ExpenseContent>
    {
        public ExpenseContentValidator()
        {
            RuleFor(x => x.ExpenseContentTitle).NotEmpty().WithMessage("GİDER ADI BOŞ GEÇİLEMEZ.")
              .MinimumLength(2).WithMessage("GİDER ADI EN AZ 2 KARAKTER İÇERMELİDİR.")
              .MaximumLength(30).WithMessage("GİDER ADI EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.ExpenseContentType).NotEmpty().WithMessage("GİDER TÜRÜ BOŞ GEÇİLEMEZ.")
                .MaximumLength(25).WithMessage("GİDER TÜRÜ EN FAZLA 25 KARAKTER OLMALI.");

            RuleFor(x => x.ExpenseContentPeceiptNumber).NotEmpty().WithMessage("FİŞ NUMARASI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("FİŞ NUMARASI EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(20).WithMessage("FİŞ NUMARASI EN FAZLA 20 KARAKTER OLMALI.");

            RuleFor(x=>x.ExpenseContentPeceiptPrice).NotEmpty().WithMessage("FİŞ GİDER ÜCRETİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ExpenseContentPeceiptImage).MaximumLength(250).WithMessage("FOTOĞRAF UZANTISI EN FAZLA 250 KARAKTER İÇERMELİ.");
            RuleFor(x => x.ExpenseContentNote).MaximumLength(250).WithMessage("GİDER NOTLARI EN FAZLA 250 KARAKTERLİ OLMALI.");
        }
    }
}
