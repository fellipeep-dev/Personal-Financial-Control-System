using Application.Dtos.User;
using Domain.Interfaces;

namespace Application.UseCases.User.UpdateUseCase
{
    public interface IUpdateUserUseCase : IUpdateUseCase<UpdateUserDto>
    {
    }
}
