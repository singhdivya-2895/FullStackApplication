using Domain;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace Application.Validators
{
    public class MyValidation : AbstractValidator<Activity>
    {
        public MyValidation()
        {
          RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("title to daal de pagal");
          RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Descritpion cannot be empty");
          RuleFor(x => x.Category)
                .NotEmpty()
                .WithMessage("Please fill the category");
          RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("bata to dooo");
          RuleFor(x => x.Venue)
                .NotEmpty()
                .WithMessage("please add venue");
          RuleFor(x => x.Date)
                .NotEmpty()
                .WithMessage("Kab jaana hai");
        }
    }
}
