namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carModelAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarModel", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Cars", "Make", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Make", c => c.String());
            DropColumn("dbo.Cars", "CarModel");
        }
    }
}
