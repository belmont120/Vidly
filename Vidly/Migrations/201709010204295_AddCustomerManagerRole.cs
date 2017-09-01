namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerManagerRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"


INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicence]) VALUES (N'0a357d46-bb5a-41e2-9e48-63f1ee3dee3f', N'customerManager@Vidly.com', 0, N'ACyw7RBhj6A2aVS4SSud4gUD4whOmyyIyVu04uZkzUo+8U9z1mgKV18OJjlqAptmIw==', N'9955ce0a-8701-4566-817c-f2c82b097365', NULL, 0, 0, NULL, 1, 0, N'customerManager@Vidly.com', N'54321')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf2641f1-5e02-4859-93ab-83191d3cd39e', N'CanManageCustomers')
                
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a357d46-bb5a-41e2-9e48-63f1ee3dee3f', N'cf2641f1-5e02-4859-93ab-83191d3cd39e')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'16c75a2d-6f67-45fb-b278-540c7fca6eb1', N'cf2641f1-5e02-4859-93ab-83191d3cd39e')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'df52d057-64ac-4452-b74f-a3de5909567d', N'cf2641f1-5e02-4859-93ab-83191d3cd39e')
                
            ");
        }
        
        public override void Down()
        {
        }
    }
}
