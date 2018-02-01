namespace FirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MovieGenres ON");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (3, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
