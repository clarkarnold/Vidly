namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreClass1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller') ");

        }

        public override void Down()
        {
        }
    }
}
