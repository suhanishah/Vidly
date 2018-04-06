namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'327d9983-15fb-4c37-b79d-0b4408ca501e', N'guest@vidly.com', 0, N'AJ3SNUJuV+LELp7dCN4U2NkH+DurSXSOnhvsFRgs8O/imvOX9lQZnfkMB3yZgf+trA==', N'27bc141b-9c58-4f61-aed0-20bfb580535a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'658a3eb2-002f-4bbd-8810-c4d11bb4024a', N'admin@vidly.com', 0, N'AHgMQatBT40iWssETZcHwVkdDomuqF9FvNT208lJ0HGKOX5PxQzOz1Fflgkn7cfHkg==', N'7fb3ed88-2c0a-418c-8d82-cbc1aa39de02', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9421c27a-f7ac-4c0c-9534-711e5a189212', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'658a3eb2-002f-4bbd-8810-c4d11bb4024a', N'9421c27a-f7ac-4c0c-9534-711e5a189212')

");
        }
        
        public override void Down()
        {
        }
    }
}
