using INTEX.Models;
using Microsoft.AspNetCore.Authorization;
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

        public QuizController(
            InferenceSession session,
            ICrashRepository temp)
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


        [HttpPost]
        public IActionResult DriverQuiz(BuzzfeedQuestions questions, QuizDriverData data)
        {


            if (questions.Question1 == "unrestrained")
            {
                data.unrestrained_True = true;
            }
            else if (questions.Question1 == "improper")
            {
                data.improper_restraint_True = true;
            }

            if (questions.Question2 == "danger")
            {
                data.bicyclist_involved_True = true;
            }

            if (questions.Question3 == "danger")
            {
                data.pedestrian_involved_True = true;
            }

            if (questions.Question4 == "danger")
            {
                data.dui_True = true;
            }

            if (questions.Question5 == "teen")
            {
                data.teenage_driver_involved_True = true;
            }

            if (questions.Question5 == "old")
            {
                data.older_driver_involved_True = true;
            }

            if (questions.Question6 == "danger")
            {
                data.drowsy_driving_True = true;
            }

            if (questions.Question7 == "danger")
            {
                data.distracted_driving_True = true;
            }

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
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return RedirectToPage("AccessDenied");

        }
    }
}
