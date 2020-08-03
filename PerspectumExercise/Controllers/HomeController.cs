using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using PerspectumExercise.Helper;
using PerspectumExercise.Models;
using PerspectumExercise.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerspectumExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Please upload a JSON File:";
            return View();
        }
        //to get form values, submitted by user
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            try
            {
                var DataFile = DeserializeHelper.Deserialize<JSONFile>(file.InputStream);
                TempData["file"] = DataFile;
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "Invalid file type. Please upload a JSON file in the correct format!";
                return View("Index");
            }
                return RedirectToAction("Index", "Main");

        }
        

        public ActionResult About()
        {
            ViewBag.Message = "This assignment is an exercise for a software developer role application!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For any clarifications regarding the please use the contacts below!";

            return View();
        }

        
    }     
}