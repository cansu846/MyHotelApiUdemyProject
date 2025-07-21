using FluentValidation;
using HotelProject.WebUI.Models.Setting;

namespace HotelProject.WebUI.ValidationRules.SettingValidationRules
{
    public class UpdateUserProfileValidator : AbstractValidator<UserEditViewModel>
    {
        public UpdateUserProfileValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş bırakılamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı alanı boş bırakılamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Uygun şekilde giriniz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Lütfen şifre tekrarını giriniz.")
                .Equal(x => x.Password).WithMessage("Lütfen şifre ile aynı olacak şekilde giriniz.");
        }
    }
}
