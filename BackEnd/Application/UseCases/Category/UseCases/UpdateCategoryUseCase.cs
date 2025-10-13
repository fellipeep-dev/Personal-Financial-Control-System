using Application.Abstractions.UseCases;
using Application.Dtos.Category;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Category.UseCases
{
    public class UpdateCategoryUseCase(
         ICategoryRepository categoryRepository,
         IMapper mapper
     ) : UpdateUseCase<CategoryEntity, UpdateCategoryDto>
     (
         categoryRepository, mapper
     ), IUpdateCategoryUseCase
    {
    }
}
