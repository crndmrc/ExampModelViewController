using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampModelViewController.Models
{
    public class DepartmanController : Controller
    {
        //global 
        InsanKaynaklariEntities _context = new InsanKaynaklariEntities();
        // GET: Personel
        public ActionResult Index()
        {
            List<Departman> dataDepartman = _context.Departman.ToList();

            return View(dataDepartman);
        }
        [HttpGet]
        public ActionResult Add()
        {

            List<Departman> dataDepartman = _context.Departman.ToList();
            ViewBag.dataDepartman = dataDepartman;
            return View();
        }
        [HttpPost]
        public ActionResult Add(Departman _departman)
        {
            _context.Departman.Add(_departman);
            _context.SaveChanges();
            return RedirectToAction("Index");
            //return View();
        }
        public ActionResult Delete(int id)
        {
            _context.Departman.Remove(_context.Departman.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}