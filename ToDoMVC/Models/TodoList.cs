using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoMVC.Models
{
    public class TodoList
    {
        //public TodoList()
        //{
        //    Items = new List<TodoListItem>();
        //}

        public string Id { get; set; }

        public String TaskName { get; set; }

        public String Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CompletedDate { get; set; }



        public virtual List<TodoListItem> Items { get; set; }
    }
}