﻿using System.Web;
using System.Web.Mvc;

namespace Pvv_lesson04
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
