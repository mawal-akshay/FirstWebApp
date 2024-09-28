using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCApp.DTO;
using MVCApp.IdentityEntities;

namespace MVCApp.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager; 
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO )
        {
            ApplicationUser user = new ApplicationUser()
            {

                Email = registerDTO.Email,
                PhoneNumber = registerDTO.Phone,
                UserName = registerDTO.Email,
                PersonName = registerDTO.PersonName

            };
           IdentityResult result= await _userManager.CreateAsync(user);

            if (result.Succeeded)
            {

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            else {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Register", error.Description);
                }
                return View(registerDTO);  
            }
        }

    }
}
