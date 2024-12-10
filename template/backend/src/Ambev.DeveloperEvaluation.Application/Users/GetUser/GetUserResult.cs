using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUser;

/// <summary>
/// Response model for GetUser operation
/// </summary>
public class GetUserResult
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The user's username
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// The user's password
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// The user's name details
    /// </summary>
    public NameDto Name { get; set; } = new NameDto();

    /// <summary>
    /// The user's address details
    /// </summary>
    public AddressDto Address { get; set; } = new AddressDto();

    /// <summary>
    /// The user's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// The current status of the user
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// The user's role in the system
    /// </summary>
    public UserRole Role { get; set; }
}

///// <summary>
///// Represents a user's name details.
///// </summary>
//public class NameDto
//{
//    /// <summary>
//    /// The user's first name
//    /// </summary>
//    public string Firstname { get; set; } = string.Empty;

//    /// <summary>
//    /// The user's last name
//    /// </summary>
//    public string Lastname { get; set; } = string.Empty;
//}

///// <summary>
///// Represents a user's address details.
///// </summary>
//public class AddressDto
//{
//    /// <summary>
//    /// The city name
//    /// </summary>
//    public string City { get; set; } = string.Empty;

//    /// <summary>
//    /// The street name
//    /// </summary>
//    public string Street { get; set; } = string.Empty;

//    /// <summary>
//    /// The street number
//    /// </summary>
//    public int Number { get; set; }

//    /// <summary>
//    /// The zip code
//    /// </summary>
//    public string Zipcode { get; set; } = string.Empty;

//    /// <summary>
//    /// The geolocation details
//    /// </summary>
//    public GeolocationDto Geolocation { get; set; } = new GeolocationDto();
//}

///// <summary>
///// Represents a geolocation with latitude and longitude.
///// </summary>
//public class GeolocationDto
//{
//    /// <summary>
//    /// The latitude
//    /// </summary>
//    public string Lat { get; set; } = string.Empty;

//    /// <summary>
//    /// The longitude
//    /// </summary>
//    public string Long { get; set; } = string.Empty;
//}
