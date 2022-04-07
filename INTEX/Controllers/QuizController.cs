using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Controllers
{
    public class QuizController : Controller
    {
        private InferenceSession _session;

        public QuizController(InferenceSession session)
        {
            _session = session;
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(QuizDriverData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<string> score = result.First().AsTensor<string>();
            var quizresult = new QuizResult { PredictedValue = score.First() };
            result.Dispose();

            return View("Result", quizresult);
        }
    }
}
