namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    Password = c.String(nullable: false, maxLength: 50, unicode: false),
                    Address = c.String(nullable: false, maxLength: 50, unicode: false),
                    CreatedAt = c.DateTime(nullable: false),
                    CreatedBy = c.Int(),
                    UpdatedAt = c.DateTime(),
                    UpdatedBy = c.Int(),
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
