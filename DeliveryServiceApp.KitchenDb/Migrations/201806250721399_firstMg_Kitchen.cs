namespace DeliveryServiceApp.KitchenDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMg_Kitchen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitchens",
                c => new
                    {
                        KitchenId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        OwnerEmail = c.String(),
                        OwnerName = c.String(),
                        OwnerPhone = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.KitchenId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kitchens");
        }
    }
}
