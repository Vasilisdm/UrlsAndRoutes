﻿using System;
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

        public ViewResult CustomVariable()
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable)
            };

            r.Data["Id"] = RouteData.Values["id"];

            return View("Result", r);
        }
    }
}
