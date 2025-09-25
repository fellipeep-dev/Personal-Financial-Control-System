using Application.Dtos.Category;
using Application.Services.Category;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [Controller]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateCategory(
            [FromBody] CreateCategoryDto createCategoryDto,
            [FromServices] ICreateCategoryUseCase _createCategoryUseCase
        )
        {
            await _createCategoryUseCase.ExecuteAsync(createCategoryDto);

            return Ok(new { Message = "Category created successfully" });
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetCategories(
            [FromServices] IGetCategoriesUseCase _getCategoriesUseCase
        )
        {
            var categories = await _getCategoriesUseCase.ExecuteAsync();

            return Ok(categories);
        }

        [HttpGet("get/{id:guid}")]
        public async Task<IActionResult> GetCategoryById(
            [FromRoute] Guid id,
            [FromServices] IGetCategoryByIdUseCase _getCategoryByIdUseCase
        )
        {
            var category = await _getCategoryByIdUseCase.ExecuteAsync(id);

            return Ok(category);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCategory(
            [FromBody] UpdateCategoryDto updateCategoryDto,
            [FromServices] IUpdateCategoryUseCase _updateCategoryUseCase
        )
        {
            await _updateCategoryUseCase.ExecuteAsync(updateCategoryDto);

            return Ok(new { Message = "Category updated successfully" });
        }

        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> DeleteCategory(
            [FromRoute] Guid id,
            [FromServices] IDeleteCategoryUseCase _deleteCategoryUseCase)
        {
            await _deleteCategoryUseCase.ExecuteAsync(id);

            return Ok(new { Message = "Category deleted successfully" });
        }
    }
}
