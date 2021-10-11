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
        private readonly IUserBllRepository _userBllRepository;

        public ClientController(IClientBllRepository ClientBllRepository, ISessionManager sessionManager, IUserBllRepository userBllRepository)
        {
            _ClientBllRepository = ClientBllRepository;
            _sessionManager = sessionManager;
            _userBllRepository = userBllRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProfilDev()
        {
            return View();
        }

        public IActionResult LoginClient()
        {
            ViewBag.Title = "Login Page";
            return View();
        }

        [HttpPost]
        public IActionResult LoginClient(LoginForm form)
        {
            ViewBag.Title = "Login Page";

            if (!ModelState.IsValid)
            {
                return View(form);
            }
            //ClientModel client = _ClientBllRepository.LoginClient(form.Email, form.Pswd).BllToAsp();
            UserModel utilisateur = _userBllRepository.ConnectClient(form.Email, form.Pswd).AspToBll();
            if (utilisateur is not null)
            {
                _sessionManager.CurrentUser = utilisateur;
                return RedirectToAction("ProfilClient", "Client");
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
                _ClientBllRepository.RegisterClient(form.AspToBll());
                return RedirectToAction("RegisterClient", "Client");
            }
        }
    }
}
