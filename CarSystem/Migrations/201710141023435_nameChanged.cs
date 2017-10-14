namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Customers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}
