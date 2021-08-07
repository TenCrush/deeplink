using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MobileAppDeepLink.Controllers
{
    [Route(".well-known")]
    public class DeepLinkController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public DeepLinkController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("apple-app-site-association")]
        public async Task<IActionResult> Apple()
        {
            return Content(await System.IO.File.ReadAllTextAsync(Path.Combine(_hostingEnvironment.WebRootPath, "apple-app-site-association")),
                "text/plain");
        }

        [Route("assetlinks.json")]
        public async Task<IActionResult> Android()
        {
            return Content(await System.IO.File.ReadAllTextAsync(Path.Combine(_hostingEnvironment.WebRootPath, "assetlinks.json")),
                "application/json");
        }
    }
}
