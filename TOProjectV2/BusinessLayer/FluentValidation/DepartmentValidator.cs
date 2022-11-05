using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        DepartmentManager _departmentManager = new DepartmentManager(new EFDepartmentDAL());
        public DepartmentValidator(string departmenName)
        {
            RuleFor(x => x.DepartmentName).NotEmpty().WithMessage("DEPARTMAN ADI BOŞ GEÇİLEMEZ.")
                .MinimumLength(2).WithMessage("DEPARTMAN EN AZ 2 KARAKTERLI OLMALI.")
                .MaximumLength(20).WithMessage("DEPARTMAN EN FAZLA 20 KARAKTERLI OLMALI.");

            if (_departmentManager.GetByDepartmenName(x=>x.DepartmentName.ToLower()==departmenName.ToLower() && x.DepartmentArchive==false))
            {
                RuleFor(w => w.DepartmentName).NotEqual(departmenName)
                                       .WithMessage("DEPARTMAN ADI SİSTEMDE KAYITLIDIR.\nKAYIT ARŞİVDEDİR. ÇIKARMAK İÇİN ARŞİV BÖLÜMÜNÜ KONTROL EDİNİZ.");
            }
            else if (_departmentManager.GetByDepartmenName(x => x.DepartmentName.ToLower() == departmenName.ToLower() && x.DepartmentArchive == true))
            {
                RuleFor(w => w.DepartmentName).NotEqual(departmenName)
                                       .WithMessage("DEPARTMAN ADI SİSTEMDE KAYITLIDIR.");
            }
           
        }
     /*   protected override bool PreValidate(ValidationContext<Department> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }*/
    }
    }
