using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator(string TC)
        {
            RuleFor(x => x.EmployeeImage).NotEmpty().WithMessage("PERSONEL FOTOĞRAFI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.DepartmentID).NotEmpty().WithMessage("PERSONEL DEPARTMANI BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.EmployeeTC).NotEmpty().WithMessage("T.C KİMLİK NUMARASI BOŞ GEÇİLEMEZ.")
                .Length(11).WithMessage("T.C KİMLİK NUMARASI EKSİKTİR.");
            //T.C KİMLİK NUMARASI İÇİN EKSTRA KONTROL.
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("PERSONEL ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("PERSONEL ADI EN AZ 2 KARAKTER İÇERMELİ.")
                .MaximumLength(20).WithMessage("PERSONEL ADI EN FAZLA 20 KARAKTERLİ OLMALI.");

            RuleFor(x => x.EmployeeSurName).NotEmpty().WithMessage("PERSONEL SOYADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("PERSONEL SOYADI EN AZ 2 KARAKTERLİ OLMALI.")
                .MaximumLength(20).WithMessage("PERSONEL SOYADI EN FAZLA 20 KARAKTERLİ OLMALI.");

            RuleFor(x => x.EmployeeGender).NotEmpty().WithMessage("PERSONEL CİNSİYETİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.EmployeeDateOfBirth).NotEmpty().WithMessage("PERSONEL DOĞUM TARİHİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.EmployeePhone).NotEmpty().WithMessage("PERSONEL TELEFON NUMARASI BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.EmployeeMail).NotEmpty().WithMessage("PERSONEL E-POSTA ADRESİ BOŞ GEÇİELEMZ.")
                .EmailAddress().WithMessage("PERSONEL E-POSTA ADRESİ UYGUN FORMATTA DEĞİLDİR.");

            RuleFor(x => x.CountyID).NotEmpty().WithMessage("PERSONEL İLİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.DistrictID).NotEmpty().WithMessage("PERSONEL İLÇESİ BOŞ GEÇİLEMEZ.");

            RuleFor(x => x.EmployeeHomeAddress).NotEmpty().WithMessage("PERSONEL ADRESİ BOŞ GEÇİLEMEZ.")
                .MinimumLength(10).WithMessage("PERSONEL ADRESİ EN AZ 10 KARAKTER İÇERMELİ.")
                .MaximumLength(250).WithMessage("PERSONEL ADRESİ EN FAZLA 250 KARAKTER OLMALI.");
        }
    }
}
