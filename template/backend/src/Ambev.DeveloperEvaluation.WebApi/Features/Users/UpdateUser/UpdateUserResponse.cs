using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Common;
using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser;

/// <summary>
/// API response model for UpdateUser operation
/// </summary>
public class UpdateUserResponse
{
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;
    public List<ValidationErrorDetail>? Errors { get; set; }
}
