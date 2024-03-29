﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class CityController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();
        public ActionResult Index()//sayfa açıldığındaki event
        {
           var values = db.TblCity.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCity()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCity(TblCity p)
        {
            db.TblCity.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");   //Girdiğim sayfaya geri gönderecek.
        }   

        public ActionResult DeleteCity(int id)
        {
            var values = db.TblCity.Find(id);
            db.TblCity.Remove(values); 
            db.SaveChanges();                   //Sqlde de kaydet
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult UpdateCity(int id)
        {
            var values = db.TblCity.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCity(TblCity p)   //Güncelleyeceğim değer
        {
            var values = db.TblCity.Find(p.CityID); //
            values.CityName = p.CityName;  //Yazacağımız değeri giriyoruz
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}