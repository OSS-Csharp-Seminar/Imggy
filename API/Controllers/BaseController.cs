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
        protected BaseRepository<T> Repository { get; set; }
        public BaseController(BaseRepository<T> Repository)
        {
            this.Repository = Repository;
        }

        [HttpGet]
        public virtual IActionResult GetAll()
        {
            return Ok(Repository.Query().ToList());
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            return Ok(Repository.Single(id));
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            var entity = Repository.Single(id);
            Repository.Remove(entity);
            Repository.Flush();
            return Ok("Deleted");
        }

        [HttpPost]
        public virtual IActionResult Create(T entity)
        {
            Repository.Persist(entity);
            Repository.Flush();
            return Ok(entity);
        }

        [HttpPut]
        public virtual IActionResult Update(T entity)
        {
            Repository.Update(entity);
            Repository.Flush();
            return Ok(entity);
        }
    }
}