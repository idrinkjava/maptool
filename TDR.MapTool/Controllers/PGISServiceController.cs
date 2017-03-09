using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDR.MapTool.Controllers
{
    public class PGISServiceController : Controller
    {
        // GET: PGISService

        [Route("PGIS_S_TileMapServer/Maps/PGISSL/EzMap")]
        public void EzMap()
        {
            this.Response.ContentType = "image/png";
            this.Response.WriteFile(Server.MapPath("/") + "images/transparent.png");
        }
    }
}