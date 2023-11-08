using BussinessLayer_.Concrete;
using BussinessLayer_.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer_.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_1.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var WriterValues = wm.GetList();
            return View(WriterValues);
        }
        [HttpGet]
        public ActionResult Addwriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        { 
            WriterValidator writervalidator = new WriterValidator();
            ValidationResult result = writervalidator.Validate(p);
            if(result.IsValid)
            {
                wm.WriteAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}