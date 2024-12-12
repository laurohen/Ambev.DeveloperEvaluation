using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;

/// <summary>
/// Represents a request to create a new user in the system.
/// </summary>
public class CreateUserRequest
{
    /// <summary>
    /// Gets or sets the username. Must be unique and contain only valid characters.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password. Must meet security requirements.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the phone number in format (XX) XXXXX-XXXX.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address. Must be a valid email format.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the initial status of the user account.
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the role assigned to the user.
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
}


