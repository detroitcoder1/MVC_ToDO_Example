namespace ToDoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoListItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128 ),
                        Priority = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Task = c.String(nullable: false),
                        TodoList_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TodoLists", t => t.TodoList_Id)
                .Index(t => t.TodoList_Id);
            
            CreateTable(
                "dbo.TodoLists",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TaskName = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        EndDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        CompletedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoListItems", "TodoList_Id", "dbo.TodoLists");
            DropIndex("dbo.TodoListItems", new[] { "TodoList_Id" });
            DropTable("dbo.TodoLists");
            DropTable("dbo.TodoListItems");
        }
    }
}
