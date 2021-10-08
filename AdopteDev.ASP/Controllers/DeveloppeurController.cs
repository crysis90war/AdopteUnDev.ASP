using AdopteDev.ASP.Mapper;
using AdopteDev.ASP.Models.Forms;
using AdopteUnDev.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Controllers
{
    public class DeveloppeurController : Controller
    {
        private readonly IDeveloppeurBllRepository _iDeveloppeurBllRepository;

        public DeveloppeurController(IDeveloppeurBllRepository iDeveloppeurBllRepository)
        {
            _iDeveloppeurBllRepository = iDeveloppeurBllRepository;
        }

        public IActionResult Index()
        {
            return View();
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
                _iDeveloppeurBllRepository.RegisterDev(form.ASPToBll());
                return RedirectToAction("Index","Home");
            }
        }


    }
}
