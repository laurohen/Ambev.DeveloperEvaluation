using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Mappers
{
    public static class UserMapper
    {
        public static object MapUserResponse(IEnumerable<GetUserResult> users, int totalItems, int currentPage, int totalPages)
        {
            return new
            {
                data = users.Select(user => new
                {
                    id = user.Id,
                    email = user.Email,
                    username = user.Username,
                    password = user.Password,
                    name = new
                    {
                        firstname = user.Name.Firstname,
                        lastname = user.Name.Lastname
                    },
                    address = new
                    {
                        city = user.Address.City,
                        street = user.Address.Street,
                        number = user.Address.Number,
                        zipcode = user.Address.Zipcode,
                        geolocation = new
                        {
                            lat = user.Address.Geolocation.Lat,
                            @long = user.Address.Geolocation.Long
                        }
                    },
                    phone = user.Phone,
                    status = Enum.GetName(typeof(UserStatus), user.Status) ?? "Unknown",
                    role = Enum.GetName(typeof(UserRole), user.Role) ?? "Unknown"
                }),
                totalItems,
                currentPage,
                totalPages
            };
        }
    }

}
