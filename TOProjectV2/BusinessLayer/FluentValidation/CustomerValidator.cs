using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerTC).NotEmpty().WithMessage("T.C KİMLİK NUMARASI BOŞ GEÇİLEMEZ.")
                .Length(11).WithMessage("T.C KİMLİK NUMARASI EKSİKTİR.");

            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("MÜŞTERİ ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("MÜŞTERİ ADI EN AZ 2 KARAKTER İÇERMELİDİR.")
                .MaximumLength(20).WithMessage("MÜŞTERİ ADI EN FAZLA 20 KARAKTER İÇERMELİDİR.");

            RuleFor(x => x.CustomerSurName).NotEmpty().WithMessage("MÜŞTERİ SOYADI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CustomerSurName).MinimumLength(2).WithMessage("MÜŞTERİ SOYADI EN AZ 2 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.CustomerSurName).MaximumLength(20).WithMessage("MÜŞTERİ SOYADI EN FAZLA 20 KARAKTER İÇERMELİDİR.");

            RuleFor(x => x.CustomerGender).NotEmpty().WithMessage("MÜŞTERİ CİNSİYETİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.CustomerDateOfBirth).NotEmpty().WithMessage("MÜŞTERİ DOĞUM TARİHİ BOŞ GEÇİLEMEZ.");

            RuleFor(x=>x.CustomerMobilePhone).NotEmpty().WithMessage("MÜŞTERİ CEP TELEFONU BOŞ GEÇİLEMEZ.");

            RuleFor(x=>x.CustomerOfficePhone).NotEmpty().WithMessage("MÜŞTERİ İŞ TELEFONU BOŞ GEÇİLEMEZ.");

            RuleFor(x=>x.CustomerMail).NotEmpty().WithMessage("MÜŞTERİ E-POSTA ADRESİ BOŞ GEÇİLEMEZ.");


            RuleFor(x => x.CountyID).NotEmpty().WithMessage("MÜŞTERİ İL BİLGİSİ SEÇİLMELİ.");
            RuleFor(x => x.DistrictID).NotEmpty().WithMessage("MÜŞTERİ İLÇE BİLGİSİ SEÇİLMELİ.");


            RuleFor(x => x.CustomerHomeAddress).NotEmpty().WithMessage("MÜŞTERİ EV ADRESİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CustomerHomeAddress).MinimumLength(20).WithMessage("MÜŞTERİ EV ADRESİ EN AZ 20 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.CustomerHomeAddress).MaximumLength(250).WithMessage("MÜŞTERİ  EV ADRESİ EN FAZLA 250 KARAKTER İÇERMELİDİR.");

            RuleFor(x => x.CustomerTaxNumber).NotEmpty().WithMessage("MÜŞTERİ VERGİ NUMARASI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CustomerTaxNumber).MinimumLength(10).WithMessage("MÜŞTERİ VERGİ NUMARASI EN AZ 10 KARAKTER İÇERMELİDİR.");
            RuleFor(x => x.CustomerTaxNumber).MaximumLength(30).WithMessage("MÜŞTERİ  VERGİ NUMARASI EN FAZLA 30 KARAKTER İÇERMELİDİR.");

            RuleFor(x => x.CustomerMail).EmailAddress().WithMessage("MÜŞTERİ E-POSTA ADRESİ EKSİK VEYA HATALI.");

        }
    }
}
