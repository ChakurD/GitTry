using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;
using Microsoft.Identity.Client.Extensions.Msal;
using Storage = Diplom.DataAccess.Entity.Storage;

namespace Diplom.Services.Service
{
    public class StorageService : ServiceConstructor, IStorageServices
    {
        public StorageService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<Storage> CreateStorage(Storage storage)
        {
            return await UnitOfWork.Storages.Create(storage);
        }

        public async Task<Storage> GetStorage(string storageName)
        {
            IList<Storage> storages = await UnitOfWork.Storages.GetAll();
            return storages.FirstOrDefault(x => x.Name == storageName);
        }

        public async Task UpdateStorage(Storage storage)
        {
            await UnitOfWork.Storages.Update(storage);
        }

        public async Task<IList<Storage>> GetAllStorages()
        {
            IList<Storage> storages = await UnitOfWork.Storages.GetAll();
            return storages;
        }
    }
}
