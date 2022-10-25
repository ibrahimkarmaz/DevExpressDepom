using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ÜRÜN ADI BOŞ BIRAKILAMAZ.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("ÜRÜN ADI EN AZ 2 KARAKTERLI OLMALI.");
            RuleFor(x => x.ProductName).MaximumLength(20).WithMessage("ÜRÜN ADI EN FAZLA 20 KARAKTERLI OLMALI.");
            RuleFor(x => x.ProductPiece).NotEmpty().WithMessage("ÜRÜN ADETİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ProductPurchasePrice).NotEmpty().WithMessage("ÜRÜN ALIŞ FİYATİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ProductSalePrice).NotEmpty().WithMessage("ÜRÜN SATIŞ FİYATİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ModelID).NotEmpty().WithMessage("ÜRÜN MODELİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.BlandID).NotEmpty().WithMessage("ÜRÜN MARKASI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.ProductDetails).MaximumLength(200).WithMessage("ÜRÜN AÇIKLAMASI EN FAZLA 200 KARAKTERLI OLMALI.");
        }
    }
}
