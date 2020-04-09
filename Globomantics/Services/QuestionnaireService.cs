using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly List<QuestionnaireModel> questionnaires = new List<QuestionnaireModel>();

        public Task AddQuestionnaire(QuestionnaireModel model, int newId)
        {
            model.QuestionnaireId = newId;
            questionnaires.Add(model);
            return Task.CompletedTask;
        }

    }
}
