﻿namespace OD.Data.Interfaces.Extensions.Pagination;

/// <summary>
///     Интерфейс запроса постранички
/// </summary>
public interface IPaginationRequest
{
    Page Page { get; set; }
}