using System.Web;
using System.Web.Mvc;

namespace WebAppProvaB2Rayane
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
