using FluentValidation;

namespace ContactManagement.Application.ContactService.Commands.CreateContact
{
    public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(50).WithMessage("Email must not exceed 50 characters.")
                .EmailAddress().WithMessage("A valid email is required.")
                .Matches(@"^\S+@\S+$").WithMessage("A valid email is required.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone is required.")
                .MaximumLength(15).WithMessage("Phone must not exceed 15 characters.");
                
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.")
                .MaximumLength(100).WithMessage("Address must not exceed 100 characters.");

            RuleFor(x => x.Company)
                .MaximumLength(50).WithMessage("Company must not exceed 50 characters.");

            RuleFor(x => x.Note)
                .MaximumLength(150).WithMessage("Note must not exceed 150 characters.");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required.");

        }   
    }
}
