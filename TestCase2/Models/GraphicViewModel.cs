using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestCase2.Utils.DrawGraphic;
using System.Web;

namespace TestCase2.Models
{
    public class GraphicViewModel : Controller
    {
        public FileContentResult graphic { get; set; }
        public List<MyPoint> Points { get; set; }
    }
}