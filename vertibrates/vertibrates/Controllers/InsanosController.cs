using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vertibrates.Models;
using System.Data.Entity;

namespace vertibrates.Controllers
{
    public class InsanosController : Controller
    {
        MainEntities mainEntity = new MainEntities();
        // GET: Insanos
        public ActionResult Index()
        {
            var list = mainEntity.project_table.ToList();
            return View(list);
        }
        private void CommonDropDown()
        {
            ViewBag.ProjetList = new SelectList(mainEntity.project_table.ToList(), "id", "name");

        }
        public ActionResult AddNew()
        {
            CommonDropDown();
            return View();
        }
        
        [HttpPost]
        public ActionResult AddNew(project_table project_table)
        {
            mainEntity.project_table.Add(project_table);
            mainEntity.SaveChanges();
            ViewBag.Message = "Saved Successful";
            CommonDropDown();
            return View();

        }

        public ActionResult Edit(int? id)
        {
            project_table project_Table = mainEntity.project_table.Find(id);
            CommonDropDown();
            return View(project_Table);
        }
      
      [HttpPost]
      public ActionResult Edit(project_table project_Table)
        {
            mainEntity.Entry(project_Table).State = EntityState.Modified;
            mainEntity.SaveChanges();
            ViewBag.Message = "Updated Successful";
            CommonDropDown();
            return View(project_Table);

        }
        public ActionResult Delete(int id)
        {
            project_table project_Table = mainEntity.project_table.Find(id);
            return View(project_Table);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            project_table old_Data = mainEntity.project_table.Find(id);
            mainEntity.project_table.Remove(old_Data);
            mainEntity.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}