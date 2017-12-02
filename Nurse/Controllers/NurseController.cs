using Dapper;
using Nurse.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nurse.Controllers
{
    public class NurseController : Controller
    {
        // GET: Nurse
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Staff()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Staff(string id = "")
        {

            StaffViewModel model = new StaffViewModel();
            if (!string.IsNullOrEmpty(id))
            {
                int st_id = Convert.ToInt32(id);
                try
                {
                    using (NurseEntities context = new NurseEntities())
                    {
                        var st = (from s in context.staff
                                  where s.id == st_id
                                  select new StaffViewModel
                                  {
                                      id = s.id,
                                      name = s.name,
                                      surname = s.surname,
                                      position = s.position
                                  }).ToList();
                        if (st != null)
                        {
                            foreach (var item in st)
                            {
                                model.id = item.id;
                                model.name = item.name;
                                model.surname = item.surname;
                                model.position = item.position;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return View(model);
        }

        public ActionResult SaveStaff(FormCollection form, StaffViewModel model)
        {
            try
            {
                using (NurseEntities context = new NurseEntities())
                {
                    staff st = new staff();
                    st.name = model.name;
                    st.surname = model.surname;
                    st.position = model.position;
                    context.staff.Add(st);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View("Staff");
        }
    }
}