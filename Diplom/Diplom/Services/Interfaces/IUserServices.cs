using Diplom.DataAccess.Entity;

namespace Diplom.Services.Interfaces
{
    public interface IUserServices
    {
        Task<User> GetUser(string login);
        Task<User> CreateUser(User user);
        Task UpdateUser(User user);
        Task<IList<User>> GetAllUsers();
    }
}
