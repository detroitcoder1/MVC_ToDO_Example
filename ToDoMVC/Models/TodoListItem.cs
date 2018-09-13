using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using ToDoMVC.Models;

namespace ToDoMVC.Models
{
    public class TodoListItem
    {
        public TodoListItem()
        {
            Priority = 0;
        }
        [Key]
        public string Id { get; set; }
        public TodoPriority Priority { get; set; }
        public TodoStatus Status { get; set; }
        [Required]
        public string Task { get; set; }
       
        
    }
}
