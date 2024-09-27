using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;
using BasicInventoryManagementSystem.Service.IService;

namespace BasicInventoryManagementSystem.Service.ImplService
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _registerRepository;

        public RegistrationService(IRegistrationRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public void RegisterUser(Registration registration)
        {
            // data is send to the repository layer
            _registerRepository.RegisterUserToDb(registration);
        }




    }
}
