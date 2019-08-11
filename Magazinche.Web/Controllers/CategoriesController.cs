using Magazinche.Services.CategoryServices;
using Magazinche.Web.Models.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Magazinche.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService CategoryService { get; set; }

        public CategoriesController(ICategoryService categoryService)
        {
            this.CategoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CategoryAddModel category)
        {
          CategoryService.Add(category);
          return  Redirect("/");
        }
        [HttpGet]
        public IActionResult All()
        {
           return View(CategoryService.All<CategoryViewModel>());
        }
    }
}
