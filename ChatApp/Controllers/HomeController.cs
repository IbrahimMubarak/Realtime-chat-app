using ChatApp.Data;
using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _users;
        private readonly ApplicationDbContext _ctx;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<User> users, ApplicationDbContext ctx)
        {
            _logger = logger;
            _users = users;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var messages = _ctx.Messages.Include("user").ToList();
            var users = _users.Users.ToList();
            ViewBag.users = users;
            return View(messages);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
