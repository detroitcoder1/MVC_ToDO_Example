using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoMVC.Repositories;
using ToDoMVC.Models;
namespace ToDoMVC.Controllers
{
    public class HomeController : Controller
    {
        private Repository<TodoList> rdb = new Repository<TodoList>(new ApplicationDbContext());
        public ActionResult Index()
        {
         var model=  rdb.GetAll().FirstOrDefault();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("TodoList", new TodoList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            return PartialView("TodoList", rdb.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(TodoList todoList)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("TodoList", todoList);
            }

            rdb.Insert(todoList);
            return new EmptyResult();
        }
    }
}