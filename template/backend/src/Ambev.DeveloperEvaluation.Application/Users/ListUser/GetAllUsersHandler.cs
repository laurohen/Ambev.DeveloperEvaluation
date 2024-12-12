using AutoMapper;
using MediatR;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate;
using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Application.Users.ListUser;

namespace Ambev.DeveloperEvaluation.Application.Users.GetAllUser;

/// <summary>
/// Handler for processing GetAllUsersCommand requests
/// </summary>
public class GetAllUsersHandler : IRequestHandler<GetAllUsersCommand, PaginatedResponse<GetUserResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUsersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<PaginatedResponse<GetUserResult>> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(request.Page, request.Size, request.Order, cancellationToken);
        var totalUsers = await _userRepository.CountAsync(cancellationToken);

        return new PaginatedResponse<GetUserResult>
        {
            Items = _mapper.Map<List<GetUserResult>>(users),
            TotalItems = totalUsers,
            PageNumber = request.Page,
            PageSize = request.Size
        };
    }
}
