using System.Web;
using System.Web.Mvc;

namespace HackerRank___Mini_Max_Sum
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
