using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.User.GetAllUseCase
{
    public interface IGetAllUsersUseCase : IGetAllUseCase<UserEntity>
    {
    }
}
