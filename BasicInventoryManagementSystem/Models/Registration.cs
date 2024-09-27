﻿using System.ComponentModel.DataAnnotations;

namespace BasicInventoryManagementSystem.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
      
        public string FirstName { get; set; }

    
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
