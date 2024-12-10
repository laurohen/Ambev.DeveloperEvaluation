﻿namespace Ambev.DeveloperEvaluation.WebApi.Common;

//public class PaginatedResponse<T> : ApiResponseWithData<IEnumerable<T>>
//{
//    public int CurrentPage { get; set; }
//    public int TotalPages { get; set; }
//    public int TotalCount { get; set; }
//}

public class PaginatedResponse<T> : ApiResponseWithData<IEnumerable<T>>
{
    public IEnumerable<T> Data { get; set; }
    public int TotalItems { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}