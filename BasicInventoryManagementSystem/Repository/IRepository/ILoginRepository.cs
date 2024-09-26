using BasicInventoryManagementSystem.Mapper.LoginMapper;
using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Repository.IRepository
{
    public interface ILoginRepository
    {
        public Login LoginUserFromDb(string email);
    }
}
