namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipNameToMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set MembershipName = 'Pay As You Go' Where Id = 1");
            Sql("Update MembershipTypes Set MembershipName = 'Monthy' Where Id = 2");
            Sql("Update MembershipTypes Set MembershipName = 'Quarterly' Where Id = 3");
            Sql("Update MembershipTypes Set MembershipName = 'Yearly' Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
