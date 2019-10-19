using Aptm2019.BusinessLogicLayer;
using Aptm2019.EntityLayer;
using Aptm2019.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aptm2019.Controllers
{
    public class EmpleadoController : Controller
    {
        private SelectList GetTipoDocumento() =>
            new SelectList(new BLL_DParametro().SelectAllByDPAR_nIdMParametro(1)
                    .Select(p => new { MEMP_nTipoDoc = p.DPAR_nId, p.DPAR_cDescripcion }), "MEMP_nTipoDoc", "DPAR_cDescripcion");
        
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
                int TotalRecordCount;
                List<ENT_MEmpleado> Records = new BLL_MEmpleado()
                    .SelectListJTable(name, null, jtStartIndex, jtPageSize, jtSorting, false, out TotalRecordCount);
                return Json(new { Result = "OK", Records, TotalRecordCount });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", ex.Message });
            }
        }

        public ActionResult Create()
        {

            ViewBag.lstTipoDocumento = GetTipoDocumento();
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formData)
        {
            try
            {
                ViewBag.lstTipoDocumento = null;//FIX
                ENT_MEmpleado emp = new ENT_MEmpleado()
                {
                    MEMP_cApeMaterno = formData["MEMP_cApeMaterno"],
                    MEMP_cApePaterno = formData["MEMP_cApePaterno"],
                    MEMP_cDireccion = formData["MEMP_cDireccion"],
                    MEMP_cNombre = formData["MEMP_cNombre"],
                    MEMP_cTelefono = formData["MEMP_cTelefono"],
                    MEMP_nTipoDoc = Int32.Parse(formData["MEMP_nTipoDoc"]),
                    MEMP_cDocumento = formData["MEMP_cDocumento"],
                    MEMP_lActivo = true,
                    MEMP_nUsrReg = 1,
                    MEMP_dFechReg = DateTime.UtcNow.AddHours(-5)
                };
                new BLL_MEmpleado().Insert(emp);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return Json(new { Result = "ERROR", ex.Message });
            }
        }
        public ActionResult Update(int id)
        {
            ViewBag.lstTipoDocumento = GetTipoDocumento();
            ENT_MEmpleado emp = new BLL_MEmpleado().Select(id);
            return View(emp);
        }
        public ActionResult Update(int id, FormCollection formData)
        {
            try
            {
                ViewBag.lstTipoDocumento = null;//FIX
                ENT_MEmpleado emp = new BLL_MEmpleado().Select(id);
                emp.MEMP_cApeMaterno = formData["MEMP_cApeMaterno"];
                emp.MEMP_cApePaterno = formData["MEMP_cApePaterno"];
                emp.MEMP_cDireccion = formData["MEMP_cDireccion"];
                emp.MEMP_cNombre = formData["MEMP_cNombre"];
                emp.MEMP_cTelefono = formData["MEMP_cTelefono"];
                emp.MEMP_nTipoDoc = Int32.Parse(formData["MEMP_nTipoDoc"]);
                emp.MEMP_cDocumento = formData["MEMP_cDocumento"];
                emp.MEMP_lActivo = true;
                emp.MEMP_nUsrReg = 1;
                emp.MEMP_dFechReg = DateTime.UtcNow.AddHours(-5);
                
                new BLL_MEmpleado().Insert(emp);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                new BLL_MEmpleado().Delete(id);
                return Json(new { Result = "OK", Message = "Se eliminó satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", ex.Message });
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