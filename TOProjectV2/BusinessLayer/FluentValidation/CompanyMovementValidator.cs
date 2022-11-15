using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CompanyMovementValidator:AbstractValidator<CompanyMovement>
    {
        public CompanyMovementValidator()
        {
            RuleFor(x => x.EmployeeID).NotEmpty().WithMessage("PERSONEL BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.CompanyID).NotEmpty().WithMessage("FİRMA BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.CompanyMovementDate).NotEmpty().WithMessage("TARİH BOŞ GEÇİLEMEZ.");
        }
    }
}
