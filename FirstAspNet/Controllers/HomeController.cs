using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstAspNet.ViewModels;
using FirstWPF.Repository;

namespace FirstAspNet.Controllers
{
    public class HomeController : Controller
    {
        //memanggil dll reff dari project sebelah
        StudentRepo studentRepo = new StudentRepo();
        public ActionResult Index()
        {
            //memanggil fungsi
            var listStudents = studentRepo.PrintStudents();
            var studentViewModel = new List<StudentViewModel>();

            foreach(var student in listStudents)
            {
                var studentVM = new StudentViewModel();
                studentVM.Name = student.Name;
                studentVM.Email = student.Email;
                studentVM.Nis = student.Nis;

                studentViewModel.Add(studentVM);
            }
            return View(studentViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}