using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;

namespace BasicInventoryManagementSystem.Repository.ImplRepository
{
    public class RegistrationRepository:IRegistrationRepository
    {
        private readonly InventoryDbContext _context; // Assuming you have an ApplicationDbContext

        public RegistrationRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public void RegisterUserToDb(Registration registration)
        {
            _context.Registrations.Add(registration);
            _context.SaveChanges();
        }
    }
}
