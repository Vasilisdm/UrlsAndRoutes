using System;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });

        public ViewResult CustomVariable(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable)
            };

            r.Data["Id"] = id ?? "<no value for id parameter provided>";
            r.Data["Url"] = Url.Action("CustomVariable", "Index", new { id = "Mon" });
            return View("Result", r);
        }
    }
}
