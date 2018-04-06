namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (GenreName) Values ('Comedy')");
            Sql("Insert Into Genres (GenreName) Values ('Action')");
            Sql("Insert Into Genres (GenreName) Values ('Romance')");
            Sql("Insert Into Genres (GenreName) Values ('Family')");
        }
        
        public override void Down()
        {
        }
    }
}
