﻿using System.Web;
using System.Web.Mvc;

namespace BibliotecaOnline.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}