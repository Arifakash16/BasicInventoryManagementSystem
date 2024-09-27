using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Mapper.LoginMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;

namespace BasicInventoryManagementSystem.Repository.ImplRepository
{
    public class LoginRepository:ILoginRepository
    {
        private readonly InventoryDbContext _context; // Assuming you have an ApplicationDbContext

        public LoginRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public Login LoginUserFromDb(string email)
        {
           // Registration dataTable = new Registration();
            var userRecord = _context.Registrations.FirstOrDefault(u => u.Email == email); //fetch the data according to email

            //Console.WriteLine(dataTable.Email + " " + dataTable.Password);

            if (userRecord != null)
            {
                return new Login
                {
                    Email = userRecord.Email,
                    Password = userRecord.Password // Ideally, do not return the password
                };
            }



            // Return null if the user record is not found
            return null;
        }
    }
}
