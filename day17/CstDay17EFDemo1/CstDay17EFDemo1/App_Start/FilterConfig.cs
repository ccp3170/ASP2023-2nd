﻿using System.Web;
using System.Web.Mvc;

namespace CstDay17EFDemo1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
