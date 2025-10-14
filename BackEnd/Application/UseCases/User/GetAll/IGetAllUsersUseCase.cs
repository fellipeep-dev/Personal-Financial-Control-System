using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.User.GetAll
{
    public interface IGetAllUsersUseCase : IGetAllUseCase<UserEntity>
    {
    }
}
