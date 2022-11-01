using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CompanyValidator:AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("FİRMA ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(10).WithMessage("FİRMA ADI 10 KARAKTERDEN AZ OLAMAZ.")
                .MaximumLength(100).WithMessage("FİRMA ADI 100 KARAKTERDEN FAZLA OLAMAZ.");

            RuleFor(x => x.CompanyOfficialTC).NotEmpty().WithMessage("FİRMA ŞİRKET YETKİLİ T.C KİMLİK NUMARASI BOŞ GEÇİLEMEZ.")
                .Length(11).WithMessage("FİRMA ŞİRKET YETKİLİ T.C KİMLİK NUMARASI EKSİK OLMAMALI.");

            RuleFor(x => x.CompanyOfficialNameSurName).NotEmpty().WithMessage("FİRMA YETKİLİ BİLGİSİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(4).WithMessage("FİRMA YETKİLİ BİLGİSİ EN AZ 4 KARAKTERLİ OLMALI.")
                .MaximumLength(30).WithMessage("FİRMA YETKİLİ BİLGİSİ EN FAZLA 30 KARAKTERLİ OLMALI.");

            RuleFor(x => x.CompanyOfficialStatus).NotEmpty().WithMessage("YETKİLİ DURUMU BOŞ GEÇİLEMEZ.")
                .MinimumLength(3).WithMessage("YETKİLİ DURUMU EN AZ 3 KARAKTERLİ OLMALI.")
                .MaximumLength(30).WithMessage("YETKİLİ DURUMU EN FAZLA 30 KARAKTERLİ OLMALI.");


            RuleFor(x => x.CompanyPhone1).NotEmpty().WithMessage("FİRMA TELEFON NUMARASI(1) BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CompanyPhone2).NotEmpty().WithMessage("FİRMA TELEFON NUMARASI(2) BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.CompanyPhone3).NotEmpty().WithMessage("FİRMA TELEFON NUMARASI(3) BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.CompanyMail).NotEmpty().WithMessage("FİRMA E-POSTA ADRESİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(10).WithMessage("FİRMA E-POSTA ADRESİ EN AZ 10 KARAKTERLİ OLMALI.")
                .MaximumLength(40).WithMessage("FİRMA E-POSTA ADRESİ EN FAZLA 40 KARAKTER OLMALI.");

            RuleFor(x => x.CompanyFax).NotEmpty().WithMessage("FİRMA FAX NUMARASI BOŞ GEÇİLEMEZ.")
                .Length(15).WithMessage("FİRMA FAX NUMARASI EN FAZLA 15 KARAKTERLİ OLMALI.");

            RuleFor(x => x.CompanyTaxOffice).NotEmpty().WithMessage("FİRMA VERGİ DAİRESİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(10).WithMessage("FİRMA VERGİ DAİRESİ EN AZ 10 KARAKTERLİ OLMALI.")
                .MaximumLength(30).WithMessage("FİRMA VERGİ DAİRESİ EN FAZLA 30 KARAKTERLİ OLMALI.");

            RuleFor(x => x.CompanyAddress).NotEmpty().WithMessage("FİRMA ADRESİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(10).WithMessage("FİRMA ADRESİ EN AZ 10 KARAKTERLİ OLMALI.")
                .MaximumLength(250).WithMessage("FİRMA ADRESİ EN FAZLA 250 KARAKTERLİ OLMALI.");

            RuleFor(x => x.CountyID).NotEmpty().WithMessage("FİRMA İLİ BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.DistrictID).NotEmpty().WithMessage("FİRMA İLÇESİ BOŞ GEÇİLEMEZ.");
        }
    }
}
