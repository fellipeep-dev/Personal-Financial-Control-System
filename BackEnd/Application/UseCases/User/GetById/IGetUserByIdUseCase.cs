using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.User.GetById
{
    public interface IGetUserByIdUseCase : IGetByIdUseCase<UserEntity>
    {
    }
}
