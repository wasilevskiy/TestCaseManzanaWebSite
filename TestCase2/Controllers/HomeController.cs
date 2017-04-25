using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestCase2.Utils.DrawGraphic;
using TestCase2.Utils;
using TestCase2.Models;
using System.Web.Mvc;

namespace TestCase2.Controllers
{
    public class HomeController : Controller
    {
        private static List<MyPoint> points;
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            TakeDataFromFile takeData = new TakeDataFromFile(Server.MapPath("~/App_Data/input.txt"));
            points = takeData.TakePoints();
            ComputationPoints comp = new ComputationPoints(points);
            points = takeData.TakePoints();
            points = comp.Compute();
            return View(points);
        }
        
        public ActionResult GetChart()
        {
            Graphic graphic = new Graphic();
            return graphic.DrawChart(points);
        }

        [HttpPost]
        public ActionResult MakeNewGraph()
        {
            ComputationPoints comp = new ComputationPoints(points);
            points = comp.Compute();
            return View("Index",points);
        }
        [HttpPost]
        public ActionResult AddPoint(int x,int y)
        {
            MyPoint p = new MyPoint();
            p.X = x;
            p.Y = y;
            points.Add(p);
            return View("Index",points);
        }
    }
}