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
        public BlandValidator()
        {
            RuleFor(x=>x.BlandName).NotEmpty().WithMessage("MARKA ADI BOŞ BIRAKILAMAZ");
            RuleFor(y => y.BlandName).MinimumLength(2).WithMessage("MARKA ADI EN AZ 2 KARAKTER İÇERMELİ");
            RuleFor(z => z.BlandName).MaximumLength(20).WithMessage("MARKA ADI EN FAZLA 20 KARAKTER OLMALI");
            //RuleFor(w=>w.BlandName).NotEqual()
        }
    }
}
