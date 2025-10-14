using Application.Abstractions.UseCases;
using Application.Dtos.Category;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Category.Create
{
    public class CreateCategoryUseCase
     (
         ICategoryRepository categoryRepository,
         IDistributedCache cache,
         IMapper mapper
     ) : CreateUseCase<CategoryEntity, CreateCategoryDto>
     (
         categoryRepository,
         cache,
         mapper
     ), ICreateCategoryUseCase
    {
    }
}
