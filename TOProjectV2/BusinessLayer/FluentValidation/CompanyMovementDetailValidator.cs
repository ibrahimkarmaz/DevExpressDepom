using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CompanyMovementDetailValidator:AbstractValidator<CompanyMovementDetail>
    {
        public CompanyMovementDetailValidator()
        {
            RuleFor(x => x.ProductID).NotEmpty().WithMessage("ÜRÜN BİLGİSİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CompanyMovementDetailPiece).NotEmpty().WithMessage("ÜRÜN ADETİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CompanyMovementDetailPrice).NotEmpty().WithMessage("ÜRÜN FİYATİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CompanyMovementDetailTotalPrice).NotEmpty().WithMessage("ÜRÜN TOPLAM FİYATİ BOŞ GEÇİLEMEZ.");
        }
    }
}
