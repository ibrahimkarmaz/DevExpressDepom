using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Entities;

namespace BusinessLayer.ValidationRules
{//Burayi kullanmak için nuger packang'den ;FluentValidation indirilmeli
    public class MusteriValidator:AbstractValidator<Musteri> //Burada benim hangi entity(Tabloda çalışacağımı belirtiyorum kütüphaneye)
    {//Ctor
        public MusteriValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Müşteri Adı boş geçilemez...");
            RuleFor(x => x.Ad).MinimumLength(2).WithMessage("En az 2 karakter girilmeli");
            RuleFor(x => x.Ad).MaximumLength(20).WithMessage("En fazla 20 karakter girilmeli");

        }
    }
}
