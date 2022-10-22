using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ModelValidator:AbstractValidator<Model>
    {
        public ModelValidator()
        {
            RuleFor(x => x.ModelName).MaximumLength(20).WithMessage("MODEL ADI EN FAZLA 20 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.ModelYear).MaximumLength(4).WithMessage("MODEL YILI EN FAZLA 4 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.ModelYear).Length(4).WithMessage("MODEL YILI 4 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.ModelName).NotEmpty().WithMessage("MODEL ADI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ModelYear).NotEmpty().WithMessage("MODEL YILI BOŞ GEÇİLEMEZ.");
        }
    }
}
