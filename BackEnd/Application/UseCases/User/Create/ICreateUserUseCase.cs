using Application.Dtos.User;
using Domain.Interfaces;

namespace Application.UseCases.User.Create
{
    public interface ICreateUserUseCase : ICreateUseCase<CreateUserDto>
    {
    }
}
