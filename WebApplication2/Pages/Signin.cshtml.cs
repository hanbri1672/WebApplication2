using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SignInPageModel : Controller
{
    private readonly DbContext _context;

    public SignInPageModel(DbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult OnPost(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

        if (user != null)
        {
            return RedirectToAction("WelcomePage");
        }
        else
        {
            ViewData["Error"] = "Invalid email or password";
            return;
        }
    }
}
