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
    public class ClientController : Controller
    {
        private readonly IClientBllRepository _ClientBllRepository;
        private readonly ISessionManager _sessionManager;


        public ClientController(IClientBllRepository ClientBllRepository, ISessionManager sessionManager)
        {
            _ClientBllRepository = ClientBllRepository;
            _sessionManager = sessionManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginClient()
        {
            ViewBag.Title = "Login Page";
            return View();
        }

        [HttpPost]
        public IActionResult LoginClient(ClientLoginForm form)
        {
            ViewBag.Title = "Login Page";

            if (!ModelState.IsValid)
            {
                return View(form);
            }
            ClientModel user = _ClientBllRepository.LoginClient(form.Email, form.Pswd).BllToAsp();
            if (user is not null)
            {
                _sessionManager.CurrentUser = user;
                return RedirectToAction("Index", "Home");
            }
            return View(form);
        }

        public IActionResult RegisterClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterClient(ClientRegisterForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                _ClientBllRepository.RegisterClient(form.ASPToBll());
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
