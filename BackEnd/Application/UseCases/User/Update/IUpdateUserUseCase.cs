using Application.Dtos.User;
using Domain.Interfaces;

namespace Application.UseCases.User.Update
{
    public interface IUpdateUserUseCase : IUpdateUseCase<UpdateUserDto>
    {
    }
}
