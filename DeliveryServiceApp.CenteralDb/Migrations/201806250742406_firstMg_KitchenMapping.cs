namespace DeliveryServiceApp.CenteralDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMg_KitchenMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KitchenMappings",
                c => new
                    {
                        KitchenMappingId = c.Int(nullable: false, identity: true),
                        KitchenId = c.Int(nullable: false),
                        KitchenOwnerEmail = c.String(),
                        LocationId = c.Int(nullable: false),
                        DbInstance = c.String(),
                    })
                .PrimaryKey(t => t.KitchenMappingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KitchenMappings");
        }
    }
}
