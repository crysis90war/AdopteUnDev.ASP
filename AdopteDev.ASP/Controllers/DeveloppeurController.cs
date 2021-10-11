using AdopteDev.ASP.Infrastructure;
using AdopteDev.ASP.Mapper;
using AdopteDev.ASP.Models;
using AdopteDev.ASP.Models.Forms;
using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Controllers
{
    public class DeveloppeurController : Controller
    {
        private readonly IDeveloppeurBllRepository _developpeurBllRepository;
        private readonly ISessionManager _sessionManager;

        public DeveloppeurController(IDeveloppeurBllRepository DeveloppeurBllRepository, ISessionManager sessionManager)
        {
            _developpeurBllRepository = DeveloppeurBllRepository;
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProfilDev()
        {
            return View();
        }

        public IActionResult LoginDev()
        {
            ViewBag.Title = "Login Page";
            return View();
        }

        [HttpPost]
        public IActionResult LoginDev(LoginForm form)
        {
            ViewBag.Title = "Login Page";

            if (!ModelState.IsValid)
            {
                return View(form);
            }
            DeveloppeurModel user = _developpeurBllRepository.LoginDev(form.Email, form.Pswd).BllToAsp();
            if (user is not null)
            {
                _sessionManager.CurrentUser = user;
                return RedirectToAction("ProfilDev", "Developpeur");
            }
            return View(form);
        }
        public IActionResult RegisterDev()
        {
                return View();
        }

        [HttpPost]
        public IActionResult RegisterDev(DevRegisterForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                _developpeurBllRepository.RegisterDev(form.AspToBll());
                return RedirectToAction("LoginDev", "Developpeur");
            }
        }


    }
}
