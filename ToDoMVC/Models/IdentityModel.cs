using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace ToDoMVC.Models
{

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext()
                : base("DefaultConnection")
            {
            }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<TodoList> TodoLists { get; set; }
        public virtual DbSet<TodoListItem> TodoListItems { get; set; }


    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}