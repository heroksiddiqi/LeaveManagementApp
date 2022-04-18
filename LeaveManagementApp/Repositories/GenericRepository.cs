using LeaveManagementApp.Contracts;
using LeaveManagementApp.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<T> AddAsync(T entity) // CREATE
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }


        public async Task DeleteAsync(int id) // DELETE based in ID
        {
            var entity = await GetAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }


        public async Task<bool> Exists(int id) // Check if data exists or not
        {
            var entity = await GetAsync(id);
            return entity != null;
        }


        public async Task<List<T>> GetAllAsync() // READ
        {
            return await context.Set<T>().ToListAsync();
        }


        public async Task<T?> GetAsync(int? id) // READ based on ID
        {
            
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity) // EDIT based on ID
        {
            
            context.Update(entity);
            await context.SaveChangesAsync();   
        }
    }
}
