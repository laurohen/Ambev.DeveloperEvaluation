using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Application.Users.DeleteUser;

/// <summary>
/// Response model for DeleteUser operation
/// </summary>
public class DeleteUserResult
{
    /// <summary>
    /// Indicates whether the deletion was successful
    /// </summary>
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;
    public List<ValidationErrorDetail>? Errors { get; set; }

}
