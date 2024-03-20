using Microsoft.AspNetCore.Mvc;

namespace MVCweek3.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Edit
        public IActionResult Edit(int ? id)
        {
            //return view
            if (id.HasValue)
                return new ContentResult { Content = id.ToString() };
            else
                return new ContentResult { Content = "Not Found Content" };
        }
    }
}
