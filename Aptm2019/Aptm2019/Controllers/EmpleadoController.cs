using Aptm2019.BusinessLogicLayer;
using Aptm2019.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aptm2019.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult EmpleadoListByFiter(string name = "", int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null)
        {
            try
            {
                //Get data from database
                List<ENT_MEmpleado> lstEmpleado = new BLL_MEmpleado().SelectAll();

                lstEmpleado = jtPageSize > 0
                       ? lstEmpleado.Skip(jtStartIndex).Take(jtPageSize).ToList() //Paging
                       : lstEmpleado.ToList();
                //Return result to jTable
                return Json(new { Result = "OK", Records = lstEmpleado, TotalRecordCount = lstEmpleado.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        //[HttpPost]
        //public JsonResult CreateStudent(Student student)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return Json(new { Result = "ERROR", Message = "Form is not valid! Please correct it and try again." });
        //        }

        //        Student addedStudent = _repository.StudentRepository.AddStudent(student);
        //        return Json(new { Result = "OK", Record = addedStudent });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        //[HttpPost]
        //public JsonResult UpdateStudent(Student student)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return Json(new { Result = "ERROR", Message = "Form is not valid! Please correct it and try again." });
        //        }

        //        _repository.StudentRepository.UpdateStudent(student);
        //        return Json(new { Result = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        //[HttpPost]
        //public JsonResult DeleteStudent(int studentId)
        //{
        //    try
        //    {
        //        _repository.StudentRepository.DeleteStudent(studentId);
        //        return Json(new { Result = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        //[HttpPost]
        //public JsonResult GetCityOptions()
        //{
        //    try
        //    {
        //        var cities = _repository.CityRepository.GetAllCities().Select(c => new { DisplayText = c.CityName, Value = c.CityId });
        //        return Json(new { Result = "OK", Options = cities });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}
    }
}