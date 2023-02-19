using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Registration.Pages
{
    public class RegisterModel : PageModel
    {
        [Required]
        [BindProperty(Name = "username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [BindProperty(Name = "password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [BindProperty(Name = "confirmPassword")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [BindProperty(Name = "email")]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Register the user in the database or other data store.
            // For simplicity, this sample code does not perform actual registration.

            return RedirectToPage("/Index");
        }
    }
}
