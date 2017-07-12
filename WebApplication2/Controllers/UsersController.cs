using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            var model = new UsersModel();
            return View(model);
        }

        public ActionResult Create(UsersModel model)
        {

            try
            {
                if (Directories.User.User.Add(new Directories.User.User
                {
                    Name = model.Name,
                    LanguageId = model.LanguageId,
                    CreationDate = DateTime.Now
                }))
                {

                    return Content("Ok");
                };

                return null;
            }
            catch (Exception ex)
            {
                Core.Log.Add(ex.ToString());
                return null;

            }
        }

        public ActionResult Delete(UsersModel model)
        {
            try
            {
                if (Directories.User.User.Delete(model.Id))
                {

                    return Content("Ok");
                };

                return null;
            }
            catch (Exception ex)
            {
                Core.Log.Add(ex.ToString());
                return null;

            }
        }

        public ActionResult Edit(UsersModel model)
        {
            return null;
        }


        public ActionResult All()
        {

            try
            {
                var result = Directories.User.User.GetAll().Select(i => new List<string> { i.ID.ToString(), i.Name, i.CreationDate.ToString(), Directories.Language.Language.GetById(i.LanguageId).Name, "", "" });
                return Json(new { aaData = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Core.Log.Add(ex.ToString());
                return null;
            }


        }
    }
}