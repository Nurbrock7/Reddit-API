using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit_API.Models;
using Microsoft.AspNetCore.Identity;
using Reddit_API.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Reddit_API.Controllers
{
    public class AccountController : Controller
    {

        private readonly DbContext _db;
        private readonly UserManager<ApplicationsUser> _userManager;
        private readonly SignInManager<ApplicationsUser> _signInManager;

        public AccountController(UserManager<ApplicationsUser> userManager, SignInManager<ApplicationsUser> signInManager, DbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
