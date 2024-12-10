namespace Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common
{
    /// <summary>
    /// Represents a user's name details.
    /// </summary>
    public class NameDto
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string Firstname { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string Lastname { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents a user's address details.
    /// </summary>
    public class AddressDto
    {
        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the street name.
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the street number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        public string Zipcode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the geolocation details.
        /// </summary>
        public GeolocationDto Geolocation { get; set; } = new GeolocationDto();
    }

    /// <summary>
    /// Represents a geolocation with latitude and longitude.
    /// </summary>
    public class GeolocationDto
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public string Lat { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public string Long { get; set; } = string.Empty;
    }
}
