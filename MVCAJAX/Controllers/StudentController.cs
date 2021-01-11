//using Domain;
using MVCAJAX.Models;
//using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCAJAX.Controllers
{
    public class StudentController: Controller
    {
        Proxy.StudentProxy proxy = new Proxy.StudentProxy();

        // GET: Student
        public ActionResult IndexRazor()
        {
            var response = Task.Run(() => proxy.GetStudentAsync());
            return View(response.Result.listado);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getStudent(string id)
        {
            var response = Task.Run(() => proxy.GetStudentAsync());
            return Json(response.Result.listado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult createStudent(StudentModel std)
        {
            //service.Insert(std);
            var response = Task.Run(() => proxy.InsertAsync(std));
            string message = response.Result.Mensaje;
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        /*[HttpPost]
        public JsonResult updateStudent(Student std, int id)
        {
            service.Update(std, id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public JsonResult deleteStudent(int id)
        {
            service.Delete(id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }*/
    }
}