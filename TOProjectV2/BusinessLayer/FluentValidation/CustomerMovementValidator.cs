using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
	public class CustomerMovementValidator:AbstractValidator<CustomerMovement>
	{
		public CustomerMovementValidator()
		{
			RuleFor(x => x.EmployeeID).NotEmpty().WithMessage("PERSONEL BOŞ GEÇİLEMEZ.");

			RuleFor(x => x.CustomerID).NotEmpty().WithMessage("MÜŞTERİ BOŞ GEÇİLEMEZ.");

			RuleFor(x => x.CustomerMovementDate).NotEmpty().WithMessage("TARİH BOŞ GEÇİLEMEZ.");
		}
	}
}
