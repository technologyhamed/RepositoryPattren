using AspNetCoreApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseDataBaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        public BaseDataBaseController(TRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetTask()
        {
            return await repository.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetTask(int Id)
        {
            var entity = await repository.GetId(Id);
            if (entity == null)
                return NotFound();
            return entity;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int Id,  TEntity Entity)
        {
            if (Entity is null)
                return BadRequest("Entity is null");
            //var entity = repository.GetId(Id);
           // if (entity == null)
              //  return BadRequest("Entity is Not Found");
           // if (entity.Id != Entity.Id)
              //  return Content("Entity is Not True");
            await repository.Update(Entity);
            return Content("Update is True");
        }
        [HttpPost]
        public async Task<IActionResult> PostTask([FromBody] TEntity Entity)
        {
            if (Entity == null)
                return NotFound();
            await repository.Add(Entity);
            return CreatedAtAction(nameof(GetTask), new { Id = Entity.Id }, Entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

    }
}
