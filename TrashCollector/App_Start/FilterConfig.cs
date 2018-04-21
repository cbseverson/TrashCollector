using System.Web;
using System.Web.Mvc;

namespace TrashCollector
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //need to add in filters here, for each employee/user
        }
    }
}
