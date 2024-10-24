namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a03ab517-b2be-4d7c-a9ed-b2c79e8a1270', N'admin@vidly.com', 0, N'AHWUuCvuFprjF+f7tawOzlCOjE44zUZNQh0N1FqZGpKsSkkxZWbLBCvtjDKjoIwZjA==', N'98f1120e-0738-4f85-b34e-8f5f627cc0bc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ecee6c39-5292-4625-98c5-518e2ec079b7', N'guest@vidly.com', 0, N'AOKxUG9KUR1JCpBcUFUshrMDoNSdzbs/l60E8n7eXMIB60OAn4UIka8lvwrG3bKrkg==', N'66f5795c-6f62-45b7-bd7a-ffb2a6bd2838', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'98314c3a-d389-4fa9-842f-7c8700ef3c52', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a03ab517-b2be-4d7c-a9ed-b2c79e8a1270', N'98314c3a-d389-4fa9-842f-7c8700ef3c52')

");
        }

        public override void Down()
        {
        }
    }
}
