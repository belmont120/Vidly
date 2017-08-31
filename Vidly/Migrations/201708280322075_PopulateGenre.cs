namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES('Comedy')");
            Sql("INSERT INTO Genres VALUES('Action')");
            Sql("INSERT INTO Genres VALUES('Family')");
            Sql("INSERT INTO Genres VALUES('Romance')");

            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Hangover','20091106', '20170828',5,1)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Die Hard','19880720', '20170828',5,2)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('The Terminator','19841026', '20170828',5,2)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Toy Story','19951119', '20170828',5,3)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Titanic','19971101', '20170828',5,4)");

        }

        public override void Down()
        {
        }
    }
}
