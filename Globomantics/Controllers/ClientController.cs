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

        public IActionResult AddCompanyUBO(int newId)
        {

            ViewBag.Title = "Add Company";
            return View(new ClientModel{ UboId = newId,ClientCounter = newId });
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyUBO(ClientModel model, int newId)
        {

            model.isSubmitted = false;
            model.UboId = newId;
            model.ClientCounter = newId;
            if (ModelState.IsValid)
            {
                
                await clientService.AddCompanyUBO(model,newId);
                model.isSubmitted = true;
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult AddCompanyCEO(int newId)
        {

            ViewBag.Title = "Add Company";
            return View(new ClientModel { CeoId = newId });
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyCEO(ClientModel model, int newId)
        {
            model.CeoId = newId;
            if (ModelState.IsValid)
            {
                await clientService.AddCompanyCEO(model, newId);

                model.isSubmitted = true;
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

            return RedirectToAction("AddCompanyUBO");
        }

       
    }
}
