using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        { 
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Bu kısım boş geçilemez.");

            RuleFor(x => x.Description).MinimumLength(20).WithMessage("En az 20 karakter girişi yapınız.");
            
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("En fazla 1500 karakter girişi yapabilirsiniz.");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Bu kısım boş geçilemez.");

        }
    }
}
