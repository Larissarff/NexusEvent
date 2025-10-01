using NexusEventBack.Models;
using NexusEventBack.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using NexusEventBack.Exceptions;

namespace NexusEventBack.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> GetUserByIdAsync(int id)
            => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<User>> GetAllUsersAsync()
            => await _repository.GetAllAsync();

        public async Task<User> CreateUserAsync(UserModel userModel)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userModel.Name))
                    throw new ValidationException("O nome do usuário não pode ser vazio.");

                if (string.IsNullOrWhiteSpace(userModel.Email))
                    throw new ValidationException("O e-mail do usuário é obrigatório.");

                if (string.IsNullOrWhiteSpace(userModel.PasswordHash))
                    throw new ValidationException("A senha do usuário é obrigatória.");

                var user = new User
                {
                    Name = userModel.Name,
                    Email = userModel.Email,
                    PasswordHash = userModel.PasswordHash,
                    Role = userModel.Role
                };

                return await _repository.AddAsync(user);
            }
            catch (ValidationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Erro ao criar usuário.", ex);
            }
        }

        public async Task<User> UpdateUserAsync(int id, UserModel userModel)
        {
            var user = new User
            {
                Id = id,
                Name = userModel.Name,
                Email = userModel.Email,
                PasswordHash = userModel.PasswordHash,
                Role = userModel.Role
            };

            return await _repository.UpdateAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<bool> RestoreUserAsync(int id)
        {
            return await _repository.RestoreAsync(id);
        }

    }
}