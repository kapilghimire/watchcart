namespace WatchCart.Orders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDetail = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Watches",
                c => new
                    {
                        WatchId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        BrandName = c.String(),
                        StrapType = c.String(),
                        StrapColor = c.String(),
                        Segment = c.String(),
                        Price = c.Int(nullable: false),
                        NumberOfHands = c.Int(),
                        HasCalender = c.Boolean(),
                        DisplayMode = c.String(),
                        HasBackLight = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.WatchId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Watches");
            DropTable("dbo.OrderDetails");
        }
    }
}
