namespace FirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesList : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, InStock, MovieGenreId) Values (1,'Margin Call', '2015.05.05','2016.06.06',5,3)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, InStock, MovieGenreId) Values (2,'Rocky', '2005.07.03','2010.01.01',5,2)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, InStock, MovieGenreId) Values (3,'Nemo', '2011.04.15','2012.02.03',5,1)");


        }

        public override void Down()
        {
        }
    }
}
