using Application.Dtos.User;
using Domain.Interfaces;

namespace Application.UseCases.User.CreateUseCase
{
    public interface ICreateUserUseCase : ICreateUseCase<CreateUserDto>
    {
    }
}
