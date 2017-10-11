namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSampleCarData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cars (Make,CarModel) VALUES ('GMC', 'Yukon')");
            Sql("INSERT INTO Cars (Make,CarModel) VALUES ('Nissan', 'Patrol')");
        }
        
        public override void Down()
        {
        }
    }
}
