using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class AutoMappingCreate : Profile
    {
        public AutoMappingCreate()
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
        }
    }
}
