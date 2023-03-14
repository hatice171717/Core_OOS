namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "LanguageID", c => c.Int());
            AddColumn("dbo.Books", "LevelID", c => c.Int());
            AddColumn("dbo.Classes", "OfficeID", c => c.Int());
            AddColumn("dbo.Educators", "LanguageID", c => c.Int());
            AddColumn("dbo.Levels", "LanguageID", c => c.Int());
            AddColumn("dbo.Sales", "StudentID", c => c.Int());
            AddColumn("dbo.Sales", "LanguageID", c => c.Int());
            AddColumn("dbo.Sales", "LevelID", c => c.Int());
            AddColumn("dbo.Sales", "BookID", c => c.Int());
            AddColumn("dbo.Sales", "ClassID", c => c.Int());
            CreateIndex("dbo.Books", "LanguageID");
            CreateIndex("dbo.Books", "LevelID");
            CreateIndex("dbo.Educators", "LanguageID");
            CreateIndex("dbo.Levels", "LanguageID");
            CreateIndex("dbo.Sales", "StudentID");
            CreateIndex("dbo.Sales", "LanguageID");
            CreateIndex("dbo.Sales", "LevelID");
            CreateIndex("dbo.Sales", "BookID");
            CreateIndex("dbo.Sales", "ClassID");
            CreateIndex("dbo.Classes", "OfficeID");
            AddForeignKey("dbo.Books", "LanguageID", "dbo.Languages", "LanguageID");
            AddForeignKey("dbo.Educators", "LanguageID", "dbo.Languages", "LanguageID");
            AddForeignKey("dbo.Books", "LevelID", "dbo.Levels", "LevelID");
            AddForeignKey("dbo.Levels", "LanguageID", "dbo.Languages", "LanguageID");
            AddForeignKey("dbo.Sales", "BookID", "dbo.Books", "BookID");
            AddForeignKey("dbo.Classes", "OfficeID", "dbo.Offices", "OfficeID");
            AddForeignKey("dbo.Sales", "ClassID", "dbo.Classes", "ClassID");
            AddForeignKey("dbo.Sales", "LanguageID", "dbo.Languages", "LanguageID");
            AddForeignKey("dbo.Sales", "LevelID", "dbo.Levels", "LevelID");
            AddForeignKey("dbo.Sales", "StudentID", "dbo.Students", "StudentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Sales", "LevelID", "dbo.Levels");
            DropForeignKey("dbo.Sales", "LanguageID", "dbo.Languages");
            DropForeignKey("dbo.Sales", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Classes", "OfficeID", "dbo.Offices");
            DropForeignKey("dbo.Sales", "BookID", "dbo.Books");
            DropForeignKey("dbo.Levels", "LanguageID", "dbo.Languages");
            DropForeignKey("dbo.Books", "LevelID", "dbo.Levels");
            DropForeignKey("dbo.Educators", "LanguageID", "dbo.Languages");
            DropForeignKey("dbo.Books", "LanguageID", "dbo.Languages");
            DropIndex("dbo.Classes", new[] { "OfficeID" });
            DropIndex("dbo.Sales", new[] { "ClassID" });
            DropIndex("dbo.Sales", new[] { "BookID" });
            DropIndex("dbo.Sales", new[] { "LevelID" });
            DropIndex("dbo.Sales", new[] { "LanguageID" });
            DropIndex("dbo.Sales", new[] { "StudentID" });
            DropIndex("dbo.Levels", new[] { "LanguageID" });
            DropIndex("dbo.Educators", new[] { "LanguageID" });
            DropIndex("dbo.Books", new[] { "LevelID" });
            DropIndex("dbo.Books", new[] { "LanguageID" });
            DropColumn("dbo.Sales", "ClassID");
            DropColumn("dbo.Sales", "BookID");
            DropColumn("dbo.Sales", "LevelID");
            DropColumn("dbo.Sales", "LanguageID");
            DropColumn("dbo.Sales", "StudentID");
            DropColumn("dbo.Levels", "LanguageID");
            DropColumn("dbo.Educators", "LanguageID");
            DropColumn("dbo.Classes", "OfficeID");
            DropColumn("dbo.Books", "LevelID");
            DropColumn("dbo.Books", "LanguageID");
        }
    }
}
