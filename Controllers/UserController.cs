using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using formSubmission.Models;

namespace formSubmission.Controllers
{
    public class UserController : Controller
    {
        public UserController(){

        }
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string firstName, string lastName, int age, string email, string Password){
            User NewUser = new User{
                firstName = firstName,
                lastName = lastName,
                age = age,
                email = email,
                Password = Password
            };
            if(TryValidateModel(NewUser)== false){
                ViewBag.ModelFields = ModelState.Values;
                return View();
            }
            else{
                return RedirectToAction("Success");
            }
        }

        [HttpGet]
        [Route("/success")]
        public IActionResult Success(){
            return View();
        }

    }
}





//         // GET: /Home/
//         [HttpGet]
//         [Route("")]
//         public IActionResult Index()
//         {
//             return View();
//         }
//     }
// }
