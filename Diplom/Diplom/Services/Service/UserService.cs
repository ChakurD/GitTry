using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;

namespace Diplom.Services.Service
{
    public class UserService : ServiceConstructor,IUserServices
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<User> CreateUser(User user)
        {
            return await UnitOfWork.Users.Create(user);
        }

        public async Task<User> GetUser(string login)
        {
            IList<User> users = await UnitOfWork.Users.GetAll();
            return users.FirstOrDefault(x => x.Login == login);
        }

        public async Task UpdateUser(User user)
        {
            await UnitOfWork.Users.Update(user);
        }

        public async Task<IList<User>> GetAllUsers() 
        {
            IList<User> users = await UnitOfWork.Users.GetAll();
            return users;
        }
    }
}
