﻿using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).SetValidator(new EmailValidator());

            RuleFor(user => user.Username)
                .NotEmpty()
                .MinimumLength(3).WithMessage("Username must be at least 3 characters long.")
                .MaximumLength(50).WithMessage("Username cannot be longer than 50 characters.");

            RuleFor(user => user.Password).SetValidator(new PasswordValidator());

            RuleFor(user => user.Phone)
                .Matches(@"^\+[1-9]\d{10,14}$")
                .WithMessage("Phone number must start with '+' followed by 11-15 digits.");

            RuleFor(user => user.Status)
                .NotEqual(UserStatus.Unknown)
                .WithMessage("User status cannot be Unknown.");

            RuleFor(user => user.Role)
                .NotEqual(UserRole.None)
                .WithMessage("User role cannot be None.");
        }
    }
}