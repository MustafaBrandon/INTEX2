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
        private ICrashRepository _repo { get; set; }
        private InferenceSession _session;

        public QuizController(InferenceSession session, ICrashRepository temp)
        {
            _session = session;
            _repo = temp;
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            ViewBag.Cities = _repo.Utah_Crashes.Select(x => x.CITY).Distinct().OrderBy(x => x).ToList();
            ViewBag.Counties = _repo.Utah_Crashes.Select(x => x.COUNTY_NAME).Distinct().OrderBy(x => x).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Calculator(QuizDriverData data)
        {
            ViewBag.Cities = _repo.Utah_Crashes.Select(x => x.CITY).Distinct().OrderBy(x => x).ToList();
            ViewBag.Counties = _repo.Utah_Crashes.Select(x => x.COUNTY_NAME).Distinct().OrderBy(x => x).ToList();

            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<string> score = result.First().AsTensor<string>();
            var calculated = new QuizResult { PredictedValue = score.First() };
            result.Dispose();
            ViewBag.Calculated = calculated.PredictedValue;

            return View();
        }

        [HttpGet]
        public IActionResult DriverQuiz()
        {

            ViewBag.Cities = _repo.Utah_Crashes.Select(x => x.CITY).Distinct().OrderBy(x => x).ToList();
            ViewBag.Counties = _repo.Utah_Crashes.Select(x => x.COUNTY_NAME).Distinct().OrderBy(x => x).ToList();

            return View();
        }
    }
}
