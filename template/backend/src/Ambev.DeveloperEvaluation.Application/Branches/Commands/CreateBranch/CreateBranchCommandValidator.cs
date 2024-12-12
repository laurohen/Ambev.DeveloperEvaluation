using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.Commands.CreateBranch
{
    public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
    {
        public CreateBranchCommandValidator()
        {
            RuleFor(sale => sale.Name).NotEmpty().NotNull().Length(3, 50);
            RuleFor(sale => sale.Location).NotEmpty().NotNull().Length(3, 100);
        }
    }
}
