using FluentValidation;
using HotelProject.WebUI.Models.Mail;

namespace HotelProject.WebUI.ValidationRules.MailValidationRules
{
    public class CreateMailValidator : AbstractValidator<AdminMailViewModel>
    {
        public CreateMailValidator()
        {
            RuleFor(x=>x.ReceiverMail).NotEmpty().WithMessage("Alıcı maili boş bırakılamaz");
            RuleFor(x=>x.ReceiverMail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
            RuleFor(x=>x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamz");
            RuleFor(x=>x.Body).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz ");
            RuleFor(x=>x.Body).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
        }
    }
}
