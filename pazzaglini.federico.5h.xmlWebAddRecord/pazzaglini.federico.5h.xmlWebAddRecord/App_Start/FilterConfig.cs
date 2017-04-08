using System.Web;
using System.Web.Mvc;

namespace pazzaglini.federico._5h.xmlWebAddRecord
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
