using System.Web;
using System.Web.Mvc;

namespace MVCAjaxWithParam2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
