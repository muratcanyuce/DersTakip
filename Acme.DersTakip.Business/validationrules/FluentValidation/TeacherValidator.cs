using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;
using FluentValidation;

namespace Acme.DersTakip.Business.validationrules.FluentValidation
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyisim boş bırakılamaz");
            RuleFor(p => p.Email).NotEmpty().When(p => string.IsNullOrEmpty(p.Phone)).WithMessage("İletişim adreslerinden en az biri girilmelidir.");
            RuleFor(p => p.Phone).NotEmpty().When(p => string.IsNullOrEmpty(p.Email)).WithMessage("İletişim adreslerinden en az biri girilmelidir.");
            RuleFor(p => p.Email).NotEmpty().Must(ContainsAt).WithMessage("Email adresi '@' karakteri içermelidir.");
        }
        private bool ContainsAt(string arg)
        {
            return arg.Contains("@");
        }
    }
}

