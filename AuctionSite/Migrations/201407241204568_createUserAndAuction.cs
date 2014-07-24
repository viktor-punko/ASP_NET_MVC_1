namespace AuctionSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUserAndAuction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        AuctionID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        FromTime = c.DateTime(nullable: false),
                        ToTime = c.DateTime(nullable: false),
                        StartRate = c.Single(nullable: false),
                        WinneUniqID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuctionID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        UniqId = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auctions", "UserID", "dbo.Users");
            DropIndex("dbo.Auctions", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Auctions");
        }
    }
}
