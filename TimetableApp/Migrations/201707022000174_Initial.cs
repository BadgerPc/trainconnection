namespace TimetableApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        TrainConnectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StationId)
                .ForeignKey("dbo.TrainConnections", t => t.TrainConnectionId, cascadeDelete: true)
                .Index(t => t.TrainConnectionId);
            
            CreateTable(
                "dbo.TrainConnections",
                c => new
                    {
                        TrainConnectionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Start = c.String(nullable: false),
                        Destination = c.String(nullable: false),
                        ConnectionType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainConnectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stations", "TrainConnectionId", "dbo.TrainConnections");
            DropIndex("dbo.Stations", new[] { "TrainConnectionId" });
            DropTable("dbo.TrainConnections");
            DropTable("dbo.Stations");
        }
    }
}
