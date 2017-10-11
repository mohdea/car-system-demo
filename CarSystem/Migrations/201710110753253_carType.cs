namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "CarType_Id", c => c.Int());
            CreateIndex("dbo.Cars", "CarType_Id");
            AddForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarType_Id", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarType_Id" });
            DropColumn("dbo.Cars", "CarType_Id");
            DropTable("dbo.CarTypes");
        }
    }
}
