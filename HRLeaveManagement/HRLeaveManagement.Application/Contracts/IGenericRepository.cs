﻿namespace HRLeaveManagement.Application.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<bool> ExistsAsync(int id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
