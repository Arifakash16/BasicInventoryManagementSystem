using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Repository.IRepository
{
    public interface IRegistrationRepository
    {
        public void RegisterUserToDb(Registration registration);
    }
}
