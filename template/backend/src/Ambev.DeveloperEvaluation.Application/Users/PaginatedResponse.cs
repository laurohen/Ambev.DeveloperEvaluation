namespace Ambev.DeveloperEvaluation.Application.Users;

/// <summary>
/// Generic response for paginated results
/// </summary>
public class PaginatedResponse<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalItems { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
