﻿namespace Suftnet.Co.Ema.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserDto
    {
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(50)]
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        public string UserType { get; set; }
    }

   
    public class UpdateUser
    {
        [Required]
        public string Id { get; set; }
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(50)]
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }

    public class RegisterDto
    {    
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Company { get; set; }        
        [StringLength(20)]
        [Required]
        public string PhoneNumber { get; set; }       
    }

    public class RemoveUser
    {
        [Required]
        public string Id { get; set; }
    }
    public class ResetUserPassword
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
   
}
