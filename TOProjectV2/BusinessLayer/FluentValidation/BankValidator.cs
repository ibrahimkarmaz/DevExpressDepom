using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class BankValidator:AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(x => x.BankName).NotEmpty().WithMessage("BANKA ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("BANKA ADI EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(30).WithMessage("BANKA ADI EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.CountyID).NotEmpty().WithMessage("BANKA İLİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.DistrictID).NotEmpty().WithMessage("BANKA İLÇESİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.BankBranch).NotEmpty().WithMessage("BANKA ŞUBESİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("BANKA ŞUBESİ EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(30).WithMessage("BANKA ŞUBESİ EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.BankBranch).NotEmpty().WithMessage("IBAN BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("IBAN EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(30).WithMessage("IBAN EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.BankAccountNo).NotEmpty().WithMessage("BANKA HESAP NUMARASI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("BANKA HESAP NUMARASI EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(30).WithMessage("BANKA HESAP NUMARASI EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.BankOfficial).NotEmpty().WithMessage("BANKA YETKİLİSİ BOŞ GEÇİLEMEZ.")
               .MinimumLength(4).WithMessage("BANKA YETKİLİSİ EN AZ 4 KARAKTER İÇERMELİ.")
               .MaximumLength(30).WithMessage("BANKA YETKİLİSİ EN FAZLA 30 KARAKTER OLMALI.");

            RuleFor(x => x.BankPhone).NotEmpty().WithMessage("BANKA TELEFONU NUMARASI BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.BankDate).NotEmpty().WithMessage("BANKA OLUŞTURMA TARİHİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.BankAccountType).NotEmpty().WithMessage("BANKA HESAP TÜRÜ BOŞ GEÇİLEMEZ.");
            //BURAYA EKLEME YAPILABİLR COMBOBOX OLMAZSA :)  +BACKTYPE



        }
    }
}
