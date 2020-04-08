using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Globomantics.Services;
using Shared.Models;
using System.Collections.Generic;

namespace WebApp.ViewComponents
{
    public class UboViewComponent : ViewComponent
    {
        private readonly IClientService service;
        public UboViewComponent(IClientService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(string statsCaption)
        {
           
            ViewBag.Caption = statsCaption;
            return View(await service.GetAll());
        }
    }
}
