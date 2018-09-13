namespace ToDoMVC.Migrations
{
    using ToDoMVC.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.TodoLists.AddOrUpdate(new TodoList
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
    }
}
