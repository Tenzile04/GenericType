﻿using Pustokk.Models;

namespace Pustokk.Services.Interfaces
{
    public interface IAuhtorService
    {
        Task CreateAsync(Author entity);
        Task Delete(int id);
        Task<Author> GetByIdAsync(int id);
        Task<List<Author>> GetAllAsync();
        Task UpdateAsync(Author entity);
    }
}
