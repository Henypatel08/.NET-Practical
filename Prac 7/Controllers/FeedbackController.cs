using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_7.Model;

namespace Practical_7.Controller
{
    public class FeedbackController : System.Web.Mvc.Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>
        {
            new Feedback
            {
                FeedbackId = 1,
                StudentName = "Heny Patel",
                FacultyName = "Dr. Sharma",
                CourseName = "Advanced Web Technology",
                Rating = 5,
                Comments = "Excellent teaching and practical explanation."
            },

            new Feedback
            {
                FeedbackId = 2,
                StudentName = "Rahul Patel",
                FacultyName = "Prof. Mehta",
                CourseName = "Database Management",
                Rating = 4,
                Comments = "Good explanation of database concepts."
            }
        };

        public ActionResult Index()
        {
            return View("~/View/Feedback/Index.cshtml", feedbackList);
        }

        public ActionResult Create()
        {
            return View("~/View/Feedback/Create.cshtml");
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.FeedbackId =
                    feedbackList.Count == 0
                    ? 1
                    : feedbackList.Max(x => x.FeedbackId) + 1;

                feedbackList.Add(feedback);

                return RedirectToAction("Index");
            }

            return View("~/View/Feedback/Create.cshtml", feedback);
        }

        public ActionResult Details(int id)
        {
            Feedback feedback = feedbackList
                .FirstOrDefault(x => x.FeedbackId == id);

            if (feedback == null)
            {
                return HttpNotFound();
            }

            return View("~/View/Feedback/Details.cshtml", feedback);
        }
    }
}