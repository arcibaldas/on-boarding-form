using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public interface IQuestionnaireService
    {

        Task AddQuestionnaire(QuestionnaireModel model, int newId);
    }
}
