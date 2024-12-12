using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings.User
{
    /// <summary>
    ///     Profile for mapping GetUser feature requests to commands
    /// </summary>
    public class GetUserProfile : Profile
    {
        /// <summary>
        ///     Initializes the mappings for GetUser feature
        /// </summary>
        public GetUserProfile()
        {
            CreateMap<Guid, GetUserQuery>()
                .ConstructUsing(id => new GetUserQuery(id));

            CreateMap<GetUserResult, GetUserResponse>()
                .ReverseMap();
        }
    }
}
