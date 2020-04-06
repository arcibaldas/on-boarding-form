using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;
using Globomantics.Services;

namespace Globomantics.Controllers
{
    public class UBOController : Controller
    {
        
        private readonly IUBOService uboService;
        private readonly IClientService clientService;


        public UBOController(IUBOService uboService,
            IClientService clientService)
        {
            this.uboService = uboService;
            this.clientService = clientService;
        }


        public IActionResult AddCompanyUBO()
        {

            ViewBag.Title = "Add UBO";
            return View(new CompanyUBO());
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyUBO(CompanyUBO model)
        {
            if (ModelState.IsValid)
            {
                await uboService.AddCompanyUBO(model);

                return View(model);
            }
            else
            {
                return View(model);
            }
        }

    }
}
