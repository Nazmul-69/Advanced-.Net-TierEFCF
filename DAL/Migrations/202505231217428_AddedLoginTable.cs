namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLoginTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Logins",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Username = c.String(nullable: false, maxLength: 50, unicode: false),
                   Password = c.String(nullable: false, maxLength: 50, unicode: false),
                   UserType = c.String(nullable: false, maxLength: 50, unicode: false),
                   UserId = c.Int(nullable: false),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
