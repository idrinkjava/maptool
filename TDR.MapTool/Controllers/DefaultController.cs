using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDR.MapTool.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MapTest()
        {
            return View();
        }

        public ActionResult TDT()
        {
            return View();
        }

        public JsonResult GetRectData(double x1, double y1, double x2, double y2)
        {
            List<Marker> markers = new List<Marker>();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                markers.Add(new Marker
                {
                    X = this.GetRandomNumber(random,x1, x2, 5),
                    Y = this.GetRandomNumber(random,y1, y2, 5),
                });
            }
            return Json(markers, JsonRequestBehavior.AllowGet);
        }
        public double GetRandomNumber(Random random,double minimum, double maximum, int Len)   //Len小数点保留位数
        {
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, Len);
        }
    }
}

/// <summary>
/// 地图上标注对象
/// </summary>
public class Marker
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Icon { get; set; }

    public int Type { get; set; }

    public double X { get; set; }

    public double Y { get; set; }
}
