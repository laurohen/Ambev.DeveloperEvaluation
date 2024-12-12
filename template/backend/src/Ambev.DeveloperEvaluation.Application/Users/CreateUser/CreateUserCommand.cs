using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.CreateUser;

/// <summary>
/// Command for creating a new user.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a user, 
/// including username, password, phone number, email, status, role, name, and address.
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CreateUserResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateUserCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateUserCommand : IRequest<CreateUserResult>
{
    /// <summary>
    /// Gets or sets the username of the user to be created.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password for the user.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the phone number for the user.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address for the user.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the status of the user.
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the role of the user.
    /// </summary>
    public UserRole Role { get; set; }

    /// <summary>
    /// Gets or sets the user's name details.
    /// </summary>
    public NameDto Name { get; set; } = new NameDto();

    /// <summary>
    /// Gets or sets the user's address details.
    /// </summary>
    public AddressDto Address { get; set; } = new AddressDto();

    /// <summary>
    /// Validates the command using the assigned validator.
    /// </summary>
    /// <returns>Validation result details.</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new CreateUserCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}

///// <summary>
///// Represents a user's name details.
///// </summary>
//public class NameDto
//{
//    /// <summary>
//    /// Gets or sets the user's first name.
//    /// </summary>
//    public string Firstname { get; set; } = string.Empty;

//    /// <summary>
//    /// Gets or sets the user's last name.
//    /// </summary>
//    public string Lastname { get; set; } = string.Empty;
//}

///// <summary>
///// Represents a user's address details.
///// </summary>
//public class AddressDto
//{
//    /// <summary>
//    /// Gets or sets the city name.
//    /// </summary>
//    public string City { get; set; } = string.Empty;

//    /// <summary>
//    /// Gets or sets the street name.
//    /// </summary>
//    public string Street { get; set; } = string.Empty;

//    /// <summary>
//    /// Gets or sets the street number.
//    /// </summary>
//    public int Number { get; set; }

//    /// <summary>
//    /// Gets or sets the zip code.
//    /// </summary>
//    public string ZipCode { get; set; } = string.Empty;

//    /// <summary>
//    /// Gets or sets the geolocation details.
//    /// </summary>
//    public GeolocationDto Geolocation { get; set; } = new GeolocationDto();
//}

///// <summary>
///// Represents a geolocation with latitude and longitude.
///// </summary>
//public class GeolocationDto
//{
//    /// <summary>
//    /// Gets or sets the latitude.
//    /// </summary>
//    public string Lat { get; set; } = string.Empty;

//    /// <summary>
//    /// Gets or sets the longitude.
//    /// </summary>
//    public string Long { get; set; } = string.Empty;
//}
