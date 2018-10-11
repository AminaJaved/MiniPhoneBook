using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice.Models;

namespace practice.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<Person> list = db.People.ToList();
            List<Person> viewList = new List<Person>();
            foreach (Person s in list)
            {
                Person c = new Person();
                c.FirstName = s.FirstName;
                c.MiddleName = s.MiddleName;
                c.LastName = s.LastName;
                c.DateOfBirth = s.DateOfBirth;
                c.AddedOn = s.AddedOn;
                c.AddedBy = s.AddedBy;
                c.HomeAddress = s.HomeAddress;
                c.HomeCity = s.HomeCity;
                c.FaceBookAccountId = s.FaceBookAccountId;
                c.LinkedIn = s.LinkedIn;
                c.UpdatedOn = s.UpdatedOn;
                c.ImagePath = s.ImagePath;
                c.TwitterId = s.TwitterId;
                c.EamilId = s.EamilId;
                
                viewList.Add(c);
            }
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person c)
        {
            try
            {
                Person s = new Person();
                s.FirstName = c.FirstName;
                s.MiddleName = c.MiddleName;
                s.LastName = c.LastName;
                s.DateOfBirth = c.DateOfBirth;
                s.AddedOn = c.AddedOn;
                s.AddedBy = c.AddedBy;
                s.HomeAddress = c.HomeAddress;
                s.HomeCity = c.HomeCity;
                s.FaceBookAccountId = c.FaceBookAccountId;
                s.LinkedIn= c.LinkedIn;
                s.UpdatedOn = c.UpdatedOn;
                s.ImagePath = c.ImagePath;
                s.TwitterId = c.TwitterId;
                s.EamilId = c.EamilId;

                PhoneBookDbEntities db = new PhoneBookDbEntities();
                db.People.Add(s);
                db.SaveChanges();
                // TODO: Add insert logic here
                // Person obj = new Person();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
