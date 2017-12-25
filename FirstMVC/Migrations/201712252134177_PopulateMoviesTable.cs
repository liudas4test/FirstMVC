namespace FirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, InStock) VALUES (1, 'The First Movie', 'Action', '2017-10-12', '2017-12-12', 5)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, InStock) VALUES (2, 'Space' , 'Documentary', '2017-10-12', '2017-12-12', 15)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, InStock) VALUES (3, 'Test Movie' , 'Commedy', '2017-10-12', '2017-12-12', 7)");
        }
        
        public override void Down()
        {
        }
    }
}
