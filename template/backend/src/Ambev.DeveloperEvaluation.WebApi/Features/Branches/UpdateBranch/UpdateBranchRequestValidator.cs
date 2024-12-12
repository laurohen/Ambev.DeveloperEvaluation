using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch
{
    public class UpdateBranchRequestValidator : AbstractValidator<UpdateBranchRequest>
    {
        public UpdateBranchRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required.")
                .MaximumLength(200).WithMessage("Location must not exceed 200 characters.");
        }
    }
}
