using BasicInventoryManagementSystem.Mapper.LoginMapper;
using BasicInventoryManagementSystem.Repository.IRepository;
using BasicInventoryManagementSystem.Service.IService;

namespace BasicInventoryManagementSystem.Service.ImplService
{
    public class LoginService:ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public bool LoginUser(string email, string password)
        {
            Login loginData = _loginRepository.LoginUserFromDb(email);
            if (loginData == null)
            {
                return false;
            }
            else if (loginData.Password != password) 
            {
                return false;
            }
            return true;
        }
    }
}
