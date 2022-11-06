using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ExpenseHeaderValidator:AbstractValidator<ExpenseHeader>
    {
        public ExpenseHeaderValidator()
        {
            RuleFor(x => x.ExorenseHeaderName).NotEmpty().WithMessage("GİDER BAŞLIĞI ADI BOŞ GEÇİLEMEZ.")
              .MinimumLength(2).WithMessage("GİDER BAŞLIĞI EN AZ 2 KARAKTER İÇERMELİDİR.")
              .MaximumLength(30).WithMessage("GİDER BAŞLIĞI EN FAZLA 30 KARAKTER OLMALI.");
            RuleFor(x => x.ExorenseHeaderStartDate).NotEmpty().WithMessage("GİDER BAŞLANGIÇ TARİHİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ExorenseHeaderStopDate).NotEmpty().WithMessage("GİDER BİTİŞ TARİHİ BOŞ GEÇİLEMEZ.");
        }
    }
}
