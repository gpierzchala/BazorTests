namespace BazorTests.Server.Managers
{
    using BazorTests.Server.Managers.Abstract;
    using BazorTests.Shared.DTOs;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserManager : IUserManager
    {
        public Task<UserDto> CreateUserAsync(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDto> GetUserAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            IEnumerable<UserDto> result = new List<UserDto>
                {
                    new UserDto
                    {
                        Id = 1,
                        UserName = "test-user",
                        Email = "test@email.com",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new UserDto
                    {
                        Id = 2,
                        UserName = "test-user-2",
                        Email = "test-2@email.com",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    }
                };

            return result;
        }
    }
}
