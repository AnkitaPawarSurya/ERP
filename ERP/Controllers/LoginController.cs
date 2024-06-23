using ERP.BusinessEntity;
using ERP.BusinessService.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ERP.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUserService _userService;

		public LoginController(IUserService userService)
		{
			_userService = userService;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(LoginViewModel loginViewModel)
		{
			var z = _userService.CheckLogin(loginViewModel.Email, loginViewModel.Password, out bool success);
		

			if (!success)
			{
				ViewBag.Error = "Invalid username and password";
			}
			else
			{
                z.RoleName = "User";
                var claims = new List<Claim>()
						{
							new Claim(ClaimTypes.NameIdentifier, Convert.ToString(z.UserId)),
							new Claim(ClaimTypes.Name, z.Email),
							new Claim(ClaimTypes.Role, z.RoleName)
						};

				var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				//Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
				var principal = new ClaimsPrincipal(identity);
				//SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
				HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
				{
					IsPersistent = false,

				});

				return RedirectToAction("Index", "User");

			}
			return View(loginViewModel);

		}
	
	}
}
	