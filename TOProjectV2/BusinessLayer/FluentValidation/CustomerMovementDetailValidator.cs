using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
	public class CustomerMovementDetailValidator:AbstractValidator<CustomerMovementDetail>
	{
		public CustomerMovementDetailValidator()
		{
			RuleFor(x => x.ProductID).NotEmpty().WithMessage("ÜRÜN BİLGİSİ BOŞ GEÇİLEMEZ.");
			RuleFor(x => x.CustomerMovementDetailPiece).NotEmpty().WithMessage("ÜRÜN ADETİ BOŞ GEÇİLEMEZ.");
			RuleFor(x => x.CustomerMovementDetailPrice).NotEmpty().WithMessage("ÜRÜN FİYATİ BOŞ GEÇİLEMEZ.");
			RuleFor(x => x.CustomerMovementDetailTotalPrice).NotEmpty().WithMessage("ÜRÜN TOPLAM FİYATİ BOŞ GEÇİLEMEZ.");
		}
	}
}
