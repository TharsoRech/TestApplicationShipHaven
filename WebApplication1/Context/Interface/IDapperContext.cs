﻿namespace WebApplication1.Context.Interface
{
    public interface IDapperContext
    {
        Task<int> ExecuteAsync(string sql, object entity);

        Task<T> QuerySingleOrDefaultAsync<T>(string sql, object entity);

        Task<T> QueryFirstOrDefaultAsync<T>(string sql, object entity = null);

        Task<T> QueryFirstAsync<T>(string sql, object entity);
    }
}
