using Application.Dtos.Category;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreateTransactionDto, TransactionEntity>();
            CreateMap<UpdateTransactionDto, TransactionEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(
                    dest => dest.Type,
                    opt => opt.Condition(src => src.Type != 0 && src.Type.HasValue)
                )
                .ForMember(
                    dest => dest.TotalInCents,
                    opt => opt.Condition(src => src.TotalInCents.HasValue)
                );

            CreateMap<CreateCategoryDto, CategoryEntity>();
            CreateMap<UpdateCategoryDto, CategoryEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(
                    dest => dest.Name,
                    opt => opt.Condition(src => !string.IsNullOrWhiteSpace(src.Name))
                )
                .ForMember(
                    dest => dest.TotalInCents,
                    opt => opt.Condition(src => src.TotalInCents.HasValue)
                )
                .ForMember(
                    dest => dest.Type,
                    opt => opt.Condition(src => src.Type != 0 && src.Type.HasValue)
                );
        }
    }
}
