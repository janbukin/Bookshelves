1) Enable migrations:
Enable-Migrations –EnableAutomaticMigrations -ProjectName Bookshelves.Data.EF.Migrations -ContextProjectName Bookshelves.Data.EF -ContextTypeName Bookshelves.Data.EF.BookshelvesDbContext
2) Set project with migrations as startup and Add migration:
Add-Migration {migrationName} -ProjectName Bookshelves.Data.EF.Migrations -ConnectionStringName BookshelvesConnection
3) Update database: Update-Database -ProjectName Bookshelves.Data.EF.Migrations