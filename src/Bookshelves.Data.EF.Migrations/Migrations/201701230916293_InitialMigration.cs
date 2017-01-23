namespace Bookshelves.Data.EF.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookGenre",
                c => new
                    {
                        Book_Id = c.Guid(nullable: false),
                        Genre_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Genre_Id })
                .ForeignKey("dbo.Book", t => t.Book_Id)
                .ForeignKey("dbo.Genre", t => t.Genre_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookGenre", "Genre_Id", "dbo.Genre");
            DropForeignKey("dbo.BookGenre", "Book_Id", "dbo.Book");
            DropIndex("dbo.BookGenre", new[] { "Genre_Id" });
            DropIndex("dbo.BookGenre", new[] { "Book_Id" });
            DropTable("dbo.BookGenre");
            DropTable("dbo.Genre");
            DropTable("dbo.Book");
        }
    }
}
