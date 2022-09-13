using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3_Student3.Models;

namespace Mvc3_Student3.Controllers
{
    public class studentController : Controller
    {
        MvcdbEntities MvcdbEntities = new MvcdbEntities();
        studViewModel studViewModel = new studViewModel();
        ViewModel ViewModel = new ViewModel();

        // GET: student
        public ActionResult Index()
        {
            List<tb2_student> _students = MvcdbEntities.tb2_student.ToList();
            List<tb2_class> _class = MvcdbEntities.tb2_class.ToList();
            List<tb2_mapping> _mapping = MvcdbEntities.tb2_mapping.ToList();
            List<tb2_subject> _subject = MvcdbEntities.tb2_subject.ToList();

            var data = (from std in _students
                        join cls in _class on std.student_clsid equals cls.class_id
                        join mp in _mapping on std.student_id equals mp.map_stdid
                        join sub in _subject on mp.map_subid equals sub.subject_id
                        select new studViewModel
                        {
                            getStudent = std,
                            getClass = cls,
                            getMapping = mp,
                            getSubject = sub
                        });

            return View(data);
           // return View();
        }
        [HttpGet]
        public ActionResult getStud()
        {
            try
            {

                //int start = Convert.ToInt32(Request["start"]);
                //int length = Convert.ToInt32(Request["length"]);
                //string search = Request["search[value]"];
                //string sortColumn = Request["order[0][column]"];// Request["columns[" +  + "][name]"];
                //string sortdir = Request["order[0][dir]"];
                //string col = Request["columns[" + Request["order[0][column]"] + "][name]"];
                //List<tb2_subject> totsub = new List<tb2_subject>();

                //using (MvcdbEntities data = new MvcdbEntities())
                //{
                //    subjects = data.tb2_subject.ToList<tb2_subject>();
                //    int totalrows = subjects.Count;

                //    if (!String.IsNullOrEmpty(search))
                //    {
                //        subjects = subjects.
                //                 Where(d => d.subject_id.ToString().Contains(search.ToLower()) ||
                //                 d.subject_name.ToLower().Contains(search.ToLower())).ToList<tb2_subject>();
                //    }
                //    int tot_filter_row = subjects.Count;
                //    //  totsub = totsub.OrderBy(col + " " + sortdir).ToList<tb2_subject>();
                //    subjects = subjects.Skip(start).Take(length).ToList<tb2_subject>();
                //    return Json(new { data = subjects, draw = Request["draw"], recordsTotal = totalrows, recordsFiltered = tot_filter_row, orderDir = sortdir, order = sortColumn }, JsonRequestBehavior.AllowGet);

                //}

                //..........

                //List<tb2_student> _students = MvcdbEntities.tb2_student.ToList();
                //List<tb2_class> _class = MvcdbEntities.tb2_class.ToList();
                //List<tb2_mapping> _mapping = MvcdbEntities.tb2_mapping.ToList();
                //List<tb2_subject> _subject = MvcdbEntities.tb2_subject.ToList();

                //var q = (from std in _students
                //         join cls in _class on std.student_clsid equals cls.class_id
                //         join mp in _mapping on std.student_id equals mp.map_stdid
                //         join sub in _subject on mp.map_subid equals sub.subject_id
                //         select new studViewModel
                //         {
                //             getStudent = std,
                //             getClass = cls,
                //             getMapping = mp,
                //             getSubject = sub
                //         }).ToList();

                //.......

                //var q = MvcdbEntities.tb2_student.ToList();

                //return Json(new { data = q }, JsonRequestBehavior.AllowGet);
                return View();
            }
            catch 
            {
                return View();
                
            }

        }

        // GET: student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: student/Create
        public ActionResult Create()
        {
            var subj = MvcdbEntities.tb2_subject.ToList();


            ViewBag.subject = (from sub in subj
                               select new ViewModel
                               {
                                   subject_id = sub.subject_id,
                                   subject_name = sub.subject_name
                               });  
            return View();
        }

        // POST: student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: student/Delete/5
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            tb2_student std = MvcdbEntities.tb2_student.Where(x => x.student_id == Id).FirstOrDefault();
            ViewModel model = new ViewModel();
            model.student_id = std.student_id;
            model.student_name = std.student_name;
            model.student_phn = std.student_phn;
            model.student_add = std.student_add;

            return PartialView(model);
        }

        // POST: student/Delete/5
        [HttpPost]
        public JsonResult Delete(studViewModel student)
        {
            // tb2_student std = db.tb2_student.Where(x => x.student_id == student_id).FirstOrDefault();
            MvcdbEntities.Entry(student).State = System.Data.Entity.EntityState.Deleted;
            MvcdbEntities.SaveChanges();

            return Json(JsonRequestBehavior.AllowGet);

        }
    }
}
