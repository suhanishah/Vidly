namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTimePropsInNewRental : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.NewRentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.NewRentals", new[] { "Customer_Id" });
            DropIndex("dbo.NewRentals", new[] { "Movie_Id" });
            AddColumn("dbo.NewRentals", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.NewRentals", "DateReturned", c => c.DateTime());
            AlterColumn("dbo.NewRentals", "Customer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.NewRentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.NewRentals", "Customer_Id");
            CreateIndex("dbo.NewRentals", "Movie_Id");
            AddForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.NewRentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewRentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.NewRentals", new[] { "Movie_Id" });
            DropIndex("dbo.NewRentals", new[] { "Customer_Id" });
            AlterColumn("dbo.NewRentals", "Movie_Id", c => c.Int());
            AlterColumn("dbo.NewRentals", "Customer_Id", c => c.Int());
            DropColumn("dbo.NewRentals", "DateReturned");
            DropColumn("dbo.NewRentals", "DateRented");
            CreateIndex("dbo.NewRentals", "Movie_Id");
            CreateIndex("dbo.NewRentals", "Customer_Id");
            AddForeignKey("dbo.NewRentals", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
