namespace BazorTests.Server.Managers.Abstract
{
    using BazorTests.Shared.DTOs;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserManager
    {
        Task<UserDto> CreateUserAsync(UserDto user);

        Task<UserDto> GetUserAsync(int id);

        Task<IEnumerable<UserDto>> GetUsersAsync();
    }
}
