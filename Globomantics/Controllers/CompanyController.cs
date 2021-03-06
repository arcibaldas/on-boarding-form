﻿using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IClientService clientService;
        private readonly ICompanyService companyService;

        public CompanyController(IClientService clientService,
            ICompanyService companyService)
        {
            this.companyService = companyService;
            this.clientService = clientService;
        }


        public async Task<IActionResult> Tables()
        {
            ViewBag.Title = "Companies";
            return View(await companyService.GetAll());
        }

        public async Task<IActionResult> Index()
        {

            ViewBag.Title = "Companies";
            return View(await companyService.GetAll());
        }


        public IActionResult AddCompanyRepresentative()
        {
            
            ViewBag.Title = "Add Company";
            return View(new CompanyModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyRepresentative(CompanyModel model)
        {

            model.isSubmitted = false;
            if (ModelState.IsValid)
            {
                await companyService.AddCompanyRepresentative(model);
                
                model.isSubmitted = true;
                return View(model);
            }
            else
            {
                return View(model);
}
        }

      



        [AcceptVerbs("GET", "POST")]
        public JsonResult VerifyEmail(string email)
        {
            if (companyService.VerifyEmail(email)==null)
            {
                return Json($"Email {email} is already in use.");
            }

            return Json(true);
        }
    }
}
