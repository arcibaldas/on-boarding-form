using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Globomantics.Services;
using Shared.Models;
using System.Collections.Generic;

namespace WebApp.ViewComponents
{
    public class StatisticsViewComponent : ViewComponent
    {
        private readonly IClientService service;
        private readonly List<UBOModel> clients = new List<UBOModel>();
        public StatisticsViewComponent(IClientService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(string statsCaption, UBOModel model)
        {
           
            ViewBag.Caption = statsCaption;
            return View(await service.GetStatistics(model));
        }
    }
}
