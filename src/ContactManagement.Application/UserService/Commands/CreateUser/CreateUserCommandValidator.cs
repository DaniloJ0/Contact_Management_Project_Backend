using FluentValidation;

namespace ContactManagement.Application.UserService.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(50).WithMessage("Email must not exceed 50 characters.")
                .EmailAddress().WithMessage("A valid email is required.")
                .Matches(@"^\S+@\S+$").WithMessage("A valid email is required.");
        }
    }
}
