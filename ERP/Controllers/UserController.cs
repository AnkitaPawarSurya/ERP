using ERP.BusinessEntity;
using ERP.BusinessService.Concrete;
using ERP.BusinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserRegi()
        {
            return View("index1");
        }

        [HttpPost]
        public IActionResult UserRegi(UserRegisterationViewModelcs URVM)
        {
            userService.UserRegister(URVM);
            
            return View("index1");
        }

        
        public IActionResult AdminRegisteration(int?id) 
        {
            if(id.HasValue)
            {
                var p = userService.GetUser(id.Value);
                return View("AdminRegisteration",p);
            }    
            return View("AdminRegisteration");
        }

        [HttpPost]
        public IActionResult AdminRegisteration(UserRegisterationViewModelcs userRegisterationViewModelcs)
        {
            userRegisterationViewModelcs.Password = "1234";
            var a = userService.UserRegister(userRegisterationViewModelcs);
            return Json(new { result = a, message = "data saved" });
        }


        public JsonResult GetData()
        {
            var a = userService.GetUser();
            return Json(new {data=a});
        }

        [HttpPost]
        public JsonResult Deleteuser(int id)
        {
            var j = userService.DeleteUser(id);

            return Json(new { result = j, message = "Data deleted Successfully" });


        }
    }
}
