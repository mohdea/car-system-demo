namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataOfCarTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarTypes (Name) VALUES ('SUV')");
            Sql("INSERT INTO CarTypes (Name) VALUES ('Sedan')");
        }
        
        public override void Down()
        {
        }
    }
}
