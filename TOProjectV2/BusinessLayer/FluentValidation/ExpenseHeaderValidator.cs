using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ExpenseHeaderValidator : AbstractValidator<ExpenseHeader>
    {
        public ExpenseHeaderValidator(string starDate, string stopDate)
        {
            RuleFor(x => x.ExprenseHeaderName).NotEmpty().WithMessage("GİDER BAŞLIĞI ADI BOŞ GEÇİLEMEZ.")
              .MinimumLength(2).WithMessage("GİDER BAŞLIĞI EN AZ 2 KARAKTER İÇERMELİDİR.")
              .MaximumLength(30).WithMessage("GİDER BAŞLIĞI EN FAZLA 30 KARAKTER OLMALI.");
            RuleFor(x => x.ExprenseHeaderStartDate).NotEmpty().WithMessage("GİDER BAŞLANGIÇ TARİHİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.ExprenseHeaderStopDate).NotEmpty().WithMessage("GİDER BİTİŞ TARİHİ BOŞ GEÇİLEMEZ.");
            try
            {
                int Difference = Convert.ToInt32(((Convert.ToDateTime(stopDate) - Convert.ToDateTime(starDate)).Days));
                Console.WriteLine(Difference.ToString());
                DateTime DifferenceDATE = Convert.ToDateTime(stopDate).AddDays(Difference);
                Console.WriteLine(DifferenceDATE.ToString());
                if (Difference < 1)
                {
                    RuleFor(x => x.ExprenseHeaderStopDate).LessThan(DifferenceDATE).WithMessage("BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN EN AZ 1 GÜN FAZLA OLMALI.");
                }
                else if (Difference > 30)
                {
                    RuleFor(x => x.ExprenseHeaderStopDate).GreaterThan(DifferenceDATE).WithMessage("BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN EN FAZLA 30 GÜN FAZLA OLMALI.");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
