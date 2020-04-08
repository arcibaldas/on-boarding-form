using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Globomantics.Controllers
{
    public class ClientController: Controller
    {
        private readonly IClientService clientService;
        private readonly ICompanyService companyService;

        public ClientController(IClientService clientService,
            ICompanyService companyService)
        {
            this.companyService = companyService;
            this.clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Conferences";
            return PartialView(await clientService.GetAll());
        }

        public IActionResult AddCompanyUBO()
        {

            ViewBag.Title = "Add Company";
            return View(new ClientModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyUBO(ClientModel model)
        {

            model.isSubmitted = false;
            if (ModelState.IsValid)
            {
                
                await clientService.AddCompanyUBO(model);
                model.isSubmitted = true;
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult AddCompanyCEO()
        {

            ViewBag.Title = "Add Company";
            return View(new ClientModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyCEO(ClientModel model)
        {
            model.isSubmitted = false;
            if (ModelState.IsValid)
            {
                await clientService.AddCompanyCEO(model);

                model.isSubmitted = true;
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult AddQuestionnaire()
        {

            ViewBag.Title = "Add Company";
            return View(new QuestionnaireModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionnaire(QuestionnaireModel model)
        {
            
            if (ModelState.IsValid)
            {
                await clientService.AddQuestionnaire(model);

               
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
        public async Task<IActionResult> Delete(ClientModel model)
        {
            if (ModelState.IsValid)
                await clientService.Delete(model);

            return RedirectToAction("Index");
        }

       
    }
}
