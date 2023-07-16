using Diplom.DataAccess.Entity;

namespace Diplom.Services.Interfaces
{
    public interface IStorageServices
    {
        Task<Storage> GetStorage(int? storageId);
        Task<Storage> CreateStorage(Storage stor);
        Task UpdateStorage(Storage stor);
        Task<IList<Storage>> GetAllStorages();
    }
}
