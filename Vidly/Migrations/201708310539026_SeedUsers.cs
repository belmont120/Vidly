namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16c75a2d-6f67-45fb-b278-540c7fca6eb1', N'admin2@vidly.com', 0, N'ADoifg5tiI5YRcrzPlIKLU1KgySg9l5dfz2SM7jgZvznh4p3Psh6+Ek9rvY+06UvzA==', N'86c39d77-f810-42e5-80df-fcb86f165ef1', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'df52d057-64ac-4452-b74f-a3de5909567d', N'admin@vidly.com', 0, N'ALKlnJsTUhaaAcX0PPqWollEMcCdnUbbGUROwB2d9R+dkLsaGdja8EHwr60jxhDbFg==', N'17743803-37f0-406e-89b6-ba8059d45979', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f847e96a-24ac-4e7f-a299-4d60f135089b', N'guest@vidly.com', 0, N'AGmhDivHqlep/8WgtxGdlHMaD0NYqdbhTr8g3mncmzYsMgIin8jeyPAMYzvNVC8aAA==', N'656d297e-19e8-4ec2-9577-d46fb978dd98', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fdab98c4-49f8-413a-a187-0f77e9f7c42f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'df52d057-64ac-4452-b74f-a3de5909567d', N'fdab98c4-49f8-413a-a187-0f77e9f7c42f')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'16c75a2d-6f67-45fb-b278-540c7fca6eb1', N'fdab98c4-49f8-413a-a187-0f77e9f7c42f')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
