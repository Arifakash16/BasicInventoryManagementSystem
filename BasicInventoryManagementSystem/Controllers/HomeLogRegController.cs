using BasicInventoryManagementSystem.Mapper.LoginMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Service.ImplService;
using BasicInventoryManagementSystem.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace BasicInventoryManagementSystem.Controllers
{
    
   
    public class HomeLogRegController : Controller
    {
        private readonly ILoginService _loginService;

        public HomeLogRegController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public ILoginService Get_loginService()
        //{
        //    return _loginService;
        //}

        [HttpPost]
        public IActionResult Index(Login login)
        {

            // Pass the registration model to the service to handle saving
            bool ok = _loginService.LoginUser(login.Email, login.Password);
            if (ok)
            {
                return Json(new { success = true, message = "Login successful" });
            }
            else
            {
                return Json(new { success = false, message = "Invalid email or password." });
            }

           // return View();

        }
    }
}
