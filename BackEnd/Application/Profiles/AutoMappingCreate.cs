using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Transaction;

namespace Application.Profiles
{
    public class AutoMappingCreate : Profile
    {
        public AutoMappingCreate()
        {
            CreateMap<CreateTransactionDto, TransactionEntity>();
        }
    }
}
