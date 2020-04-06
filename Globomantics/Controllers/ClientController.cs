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

        public async Task<IActionResult> Index(int Id)
        {
            var member = await companyService.GetById(Id);
            ViewBag.Title = $"Users of company {member.Name} ";

            return View(await clientService.GetAll(Id));
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Register new UBO Client";
            return View(new ClientModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClientModel model)
        {
            

            if (ModelState.IsValid)
            {
                
                await clientService.Add(model);

                if (model.UserCounter > 4)
                {
                    model.isSubmitted = false;
                }

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
