using Diplom.DataAccess.DbPatterns.Interfaces;

namespace Diplom.Services.Service
{
    public class ServiceConstructor
    {
        protected IUnitOfWork UnitOfWork;

        protected ServiceConstructor(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
