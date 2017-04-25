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
        public ActionResult Index()
        {
            GraphicViewModel graph = new GraphicViewModel();
            Graphic gr = new Graphic();
            TakeDataFromFile takeData = new TakeDataFromFile(Server.MapPath("~/App_Data/input.txt"));
            graph.Points = takeData.TakePoints();
            ComputationPoints comp = new ComputationPoints(graph.Points);
            graph.Points = comp.Compute();
            graph.graphic = gr.DrawChart(graph.Points);
           /* points = takeData.TakePoints();
            ComputationPoints comp = new ComputationPoints(points);
            points = comp.Compute();*/
            return View(graph);
        }
        public ActionResult GetChart(List<MyPoint> p)
        {
            /*
            TakeDataFromFile takeData = new TakeDataFromFile(Server.MapPath("~/App_Data/input.txt"));
            points = takeData.TakePoints();
            ComputationPoints comp = new ComputationPoints(points);
            points = comp.Compute();*/
            Graphic graphic = new Graphic();
            return graphic.DrawChart(points);
        }


       
      
    }
}