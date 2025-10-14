using Application.Abstractions.UseCases;
using Application.Dtos.Category;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Category.Create
{
    public class CreateCategoryUseCase
     (
         ICategoryRepository categoryRepository,
         IMapper mapper
     ) : CreateUseCase<CategoryEntity, CreateCategoryDto>
     (
         categoryRepository, mapper
     ), ICreateCategoryUseCase
    {
    }
}
