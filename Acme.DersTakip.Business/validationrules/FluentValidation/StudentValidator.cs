using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;
using FluentValidation;

namespace Acme.DersTakip.Business.validationrules.FluentValidation
{
    public class StudentValidator: AbstractValidator<Student>
    {
        public StudentValidator() 
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim boş bırakılamaz.");
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyisim boş bırakılamaz.");
            RuleFor(p => p.Phone).Matches("^\\d{11}$").WithMessage("Telefon Numarası 11 haneli olmalı ve sadece rakamlardan oluşmalıdır. \n --Örnek:12345678901 \n");
        }
    }
}
