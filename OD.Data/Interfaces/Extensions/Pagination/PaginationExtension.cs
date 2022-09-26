﻿using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace OD.Data.Interfaces.Extensions.Pagination;

public static class PaginationExtension
{
    /// <summary>
    ///     Получить список постранично
    /// </summary>
    /// <typeparam name="TResModel">Результирующая модель типа IPaginationResponse</typeparam>
    /// <typeparam name="TSource">Тип записей в таблице БД (Entity)</typeparam>
    /// <typeparam name="TResult">Выходная модель селектора</typeparam>
    /// <param name="query">Запрос типа IQueryable</param>
    /// <param name="request">Запрос постранички IPaginationRequest</param>
    /// <param name="selector">Выражение селектора</param>
    /// <returns></returns>
    public static async Task<TResModel> GetPageAsync<TResModel, TSource, TResult>(this IQueryable<TSource> query,
        IPaginationRequest request, Expression<Func<TSource, TResult>> selector)
        where TResModel : IPaginationResponse<TResult>, new() where TResult : class
    {
        var count = await query.LongCountAsync();

        var items = await query.Page(request.Page)
            .Select(selector)
            .ToArrayAsync();

        return new TResModel
        {
            Items = items,
            Page = request.Page,
            Count = count
        };
    }
}