using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Application.Interfaces.Repository;
using TestApp.Domain.Common;
using TestApp.Persistence.Context;

namespace TestApp.Persistence.Repositories
{
	public class GenericRepository<T>: IGenericRepositoryAsync<T> where T : BaseEntity
	{
		private readonly ApplicationDbContext dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
			this.dbContext = dbContext;
        }
        public async Task<List<T>> GetAllAsync()
		{
			return await dbContext.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(Guid id)
		{
			return await dbContext.Set<T>().FindAsync(id) ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
		}

		public async Task<T> AddAsync(T entity)
		{
			await dbContext.Set<T>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
			return entity;
		}
	}
}
