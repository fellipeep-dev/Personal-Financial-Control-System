using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.User.GetByIdUseCase
{
    public interface IGetUserByIdUseCase : IGetByIdUseCase<UserEntity>
    {
    }
}
