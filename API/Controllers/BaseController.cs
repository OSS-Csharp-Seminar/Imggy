using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories;

namespace API.Controllers
{
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected BaseRepository<T> BaseRepository { get; set; }
        public BaseController(BaseRepository<T> Repository)
        {
            BaseRepository = Repository;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await BaseRepository.Query().ToListAsync();
        }

        [HttpGet("{id}")]
        public virtual async Task<T> GetAsync(int id)
        {
            return await BaseRepository.SingleAsync(id);
        }

        [HttpDelete("{id}")]
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await BaseRepository.SingleAsync(id);
            BaseRepository.Remove(entity);
            await BaseRepository.FlushAsync();
        }

        [HttpPost]
        public virtual async Task<T> CreateAsync(T entity)
        {
            await BaseRepository.PersistAsync(entity);
            await BaseRepository.FlushAsync();
            return entity;
        }

        [HttpPost]
        public virtual async Task<T> UpdateAsync(T entity)
        {
            BaseRepository.Update(entity);
            await BaseRepository.FlushAsync();
            return entity;
        }
    }
}