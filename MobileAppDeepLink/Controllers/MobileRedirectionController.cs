using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileAppDeepLink.Controllers
{
    [Route("mobile-redirection")]
    public class MobileRedirectionController : Controller
    {
        [Route("detail-video/{id}")]
        [HttpGet]
        public async Task<string> DetailVideo([FromRoute] int id)
        {
            return "Không có gì đâu mà vào!!";
        }

    }
}
