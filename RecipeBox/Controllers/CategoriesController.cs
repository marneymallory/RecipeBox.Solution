using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Controllers
{
  public class CategoriesControler : Controller
  {
    private readonly RecipeBoxContext _db;
    public CategoriesController(RecipeBoxContext db)
    {
      _db = db;
    }
    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> model = _db.Categories.ToList();
      return View(model);
    }
    [HttpGet("/categories/create")]
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost("/categories/create")]
    public ActionResult Create(Category category)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisCategory = _db.Categories
      .Include(category => category.JoinEntities)
      .ThenInclude(join => join.Recipe)
      .FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    public ActionResult Edit(int id)
    {
      var thisRecipe = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisRecipe);
    }
    [HttpPost]
    public ActionResult Edit(Category category)
    {
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      .SaveChanges();
      return RedirectToAction("Index");
    }
  }
}












  }












}