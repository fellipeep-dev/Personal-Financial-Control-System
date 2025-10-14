using Application.Abstractions.UseCases;
using Application.Dtos.Category;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Category.Update
{
    public class UpdateCategoryUseCase(
         ICategoryRepository categoryRepository,
         IDistributedCache cache,
         IMapper mapper
     ) : UpdateUseCase<CategoryEntity, UpdateCategoryDto>
     (
         categoryRepository,
         cache,
         mapper
     ), IUpdateCategoryUseCase
    {
    }
}
