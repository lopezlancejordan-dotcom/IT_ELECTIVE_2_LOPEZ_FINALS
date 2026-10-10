using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_LOPEZ_FINALS.Models;
using System.Collections.Generic;

namespace IT_ELECTIVE_2_LOPEZ_FINALS.Controllers
{
    public class FinalsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentName = "Lance Jordan V. Lopez";
            ViewBag.StudentId = "2000-24";
            ViewBag.Section = "BSIT-31E3";
            ViewBag.Role = "S5 - Documentation & QA Engineer";

            var qaTasks = new List<QATaskModel>
            {
                new QATaskModel
                {
                    IssueId = 19,
                    Title = "SSO Authentication Bug Verification and QA Testing",
                    Team = "S5",
                    Type = "QA",
                    Status = "Shipped / Complete",
                    DirectUrl = "https://github.com/lopezlancejordan-dotcom/IT_ELECTIVE_2_LOPEZ_FINALS/issues/19"
                }
            };

            return View(qaTasks);
        }

        public IActionResult SSODocumentation()
        {
            ViewBag.Title = "SSO Integration Guide";
            return View();
        }
    }
}