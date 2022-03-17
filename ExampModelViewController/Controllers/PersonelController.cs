using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampModelViewController.Models
{
    public class PersonelController : Controller
    {
        //global 
        InsanKaynaklariEntities _context = new InsanKaynaklariEntities();
        // GET: Personel
        public ActionResult Index()
        {
            List<Personel> dataPersonel = _context.Personel.ToList();

            return View(dataPersonel);
        }
        [HttpGet]
        public ActionResult Add()
        {
            List<Personel> dataPersonel = _context.Personel.ToList();
            ViewBag.dataPersonel = dataPersonel;

            List<Departman> dataDepartman = _context.Departman.ToList();
            ViewBag.dataDepartman = dataDepartman;

            return View();
        }
        [HttpPost]
        public ActionResult Add(Personel _personel)
        {
            _personel.Departman = _context.Departman.Find(_personel.departman_id);

            _context.Personel.Add(_personel);
            _context.SaveChanges();

            return RedirectToAction("Index");
            //return View();
        }
        public ActionResult Delete(int id)
        {
            _context.Personel.Remove(_context.Personel.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}