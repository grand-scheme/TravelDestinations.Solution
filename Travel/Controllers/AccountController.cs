using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Travel.Models;
using Travel.ViewModels;
using System.Linq;


namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountController : ControllerBase
  {
    private readonly TravelContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, TravelContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }


    [HttpPost("register")]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return Created(string.Empty, string.Empty);
      }
      else
      {
        return NotFound();
      }
    }


    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost("logoff")]
    public async Task<ActionResult> LogOff()
    {
        await _signInManager.SignOutAsync();
        return Ok();
    }
  }
}