using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Globomantics.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireService questionnaireService;

        public QuestionnaireController(IQuestionnaireService questionnaireService)
        {
            this.questionnaireService = questionnaireService;


        }

        public IActionResult AddQuestionnaire(int newId)
        {

            ViewBag.Title = "Add Company Questionnaire";
            return View(new QuestionnaireModel { QuestionnaireId=newId });
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionnaire(QuestionnaireModel model, int newId)
        {

            model.QuestionnaireId = newId;
            model.isSubmitted = false;
            if (ModelState.IsValid)
            {

                await questionnaireService.AddQuestionnaire(model, newId);
                model.isSubmitted = true;
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
    }
}