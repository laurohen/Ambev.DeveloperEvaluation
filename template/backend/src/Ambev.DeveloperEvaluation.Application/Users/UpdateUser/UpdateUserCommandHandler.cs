using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UpdateUserResult> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateUserCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
        {
            return new UpdateUserResult
            {
                Success = false,
                Message = "Validation failed",
                Errors = validationResult.Errors.Select(e => new ValidationErrorDetail
                {
                    PropertyName = e.PropertyName,
                    ErrorMessage = e.ErrorMessage
                }).ToList()
            };
        }

        // Fetch the user entity from the repository by Id.
        var user = await _userRepository.GetByIdAsync(command.Id, cancellationToken);

        if (user == null)
        {
            return new UpdateUserResult
            {
                Success = false,
                Message = $"User with Id {command.Id} not found."
            };
        }

        user.Update(
            command.Username,
            command.Password,
            command.Phone,
            command.Email,
            command.Status,
            command.Role,
            new NameDto
            {
                Firstname = command.FirstName,
                Lastname = command.LastName
            },
            new AddressDto
            {
                City = command.Address.City,
                Street = command.Address.Street,
                Number = command.Address.Number,
                Zipcode = command.Address.Zipcode,
                Geolocation = new GeolocationDto
                {
                    Lat = command.Address.Geolocation.Lat,
                    Long = command.Address.Geolocation.Long
                }
            }
        );

        // Save the updated user in the repository.
        var updatedUser = await _userRepository.UpdateAsync(user, cancellationToken);

        // Return the result using AutoMapper.
        return _mapper.Map<UpdateUserResult>(updatedUser);
    }
}
