using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ToDoMVC.Models;
using ToDoMVC.Repositories;
//using ToDoMVC.Services;

namespace ToDoMVC.Controllers
{
    public class TodoListsController : Controller
    {
        private Repository<TodoList> rdb = new Repository<TodoList>(new ApplicationDbContext());
        private Repository<TodoListItem> idb = new Repository<TodoListItem>(new ApplicationDbContext());
        private ApplicationDbContext db = new ApplicationDbContext();
        public TodoListsController()


        {
            rdb.Insert(new TodoList
            {
                TaskName = " Work to do",
                Description = "Culviner",
                Items = new List<TodoListItem>
                            {
                                new TodoListItem
                                {
                                     Status = 0,
                                    Priority = 0,
                                    Task = "Clean house"
                                },
                                new TodoListItem
                                {
                                    Status = 0,
                                    Priority = 0,
                                    Task = "Write code"
                                },
                                new TodoListItem
                                {
                                    Status =0,
                                    Priority = 0,
                                    Task = "Mow lawn"
                                }
                            }
            });

        }

        public ActionResult Index( )
        {
          
           


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
            if (!ModelState.IsValid){
                return PartialView("TodoList", todoList);
            }

            rdb.Insert(todoList);
            return new EmptyResult();
        }
    }
}
