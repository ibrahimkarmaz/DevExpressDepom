using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class SectorValidator:AbstractValidator<Sector>
    {
        public SectorValidator()
        {
            RuleFor(x => x.SectorName).NotEmpty().WithMessage("SEKTÖR ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(5).WithMessage("SEKTÖR ADI 5 KARAKTERDEN AZ OLAMAZ.")
                .MaximumLength(40).WithMessage("SEKTÖR ADI 40 KARAKTERDEN FAZLA OLAMAZ.");
        }
    }
}
