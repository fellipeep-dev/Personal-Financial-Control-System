using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Abstractions
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerAbstraction
     <
        TEntity,
        TCreateDto,
        TUpdateDto,
        TCreateUseCase,
        TGetAllUseCase,
        TGetByIdUseCase,
        TUpdateuseCase,
        TDeleteUseCase
     > : ControllerBase
        where TCreateUseCase : ICreateUseCase<TCreateDto>
        where TGetAllUseCase : IGetAllUseCase<TEntity>
        where TGetByIdUseCase : IGetByIdUseCase<TEntity>
        where TUpdateuseCase : IUpdateUseCase<TUpdateDto>
        where TDeleteUseCase : IDeleteUseCase
        where TEntity : Entity
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] TCreateDto createDto,
            [FromServices] TCreateUseCase _createUseCase)
        {
            await _createUseCase.ExecuteAsync(createDto);

            return Ok(new { Message = "Created successfully" });
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetAll(
            [FromServices] TGetAllUseCase _getAllUseCase)
        {
            var entities = await _getAllUseCase.ExecuteAsync();

            return Ok(entities);
        }

        [HttpGet("get/{id:guid}")]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid id,
            [FromServices] TGetByIdUseCase _getByIdUseCase)
        {
            var entity = await _getByIdUseCase.ExecuteAsync(id);
         
            return Ok(entity);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(
            [FromBody] TUpdateDto updateDto,
            [FromServices] TUpdateuseCase _updateUseCase)
        {
            await _updateUseCase.ExecuteAsync(updateDto);

            return Ok(new { Message = "Updated successfully" });
        }

        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid id,
            [FromServices] TDeleteUseCase _deleteUseCase)
        {
            await _deleteUseCase.ExecuteAsync(id);
         
            return Ok(new { Message = "Deleted successfully" });
        }
    }
}
