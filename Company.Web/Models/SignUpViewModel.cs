﻿using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Format For Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_])(?!.*(.).*\1.*\1).{6,}$",
        ErrorMessage = "Password must be at least 6 characters long, contain at least 1 digit, 1 lowercase letter, 1 uppercase letter, 1 special character, and 2 unique characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare(nameof(Password), ErrorMessage = "ConfirmPassword does not match Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Required to Agree ")]
        public bool IsAgree { get; set; }

        // zy el dto bahto fi feh bs el hagat ali ana 3yzha
    }
}
