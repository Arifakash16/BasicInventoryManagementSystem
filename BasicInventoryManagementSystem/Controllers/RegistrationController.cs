using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace BasicInventoryManagementSystem.Controllers
{
    [Route("registration")]
    [ApiController]
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Registration registration)
        {
            
                // Pass the registration model to the service to handle saving
                _registrationService.RegisterUser(registration);
              
                return View();

        }

    }
}
