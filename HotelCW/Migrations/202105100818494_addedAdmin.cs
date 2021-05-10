namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminName = c.String(),
                        AdminPassword = c.String(),
                        AdminControlword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rooms", "AdminId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rooms", "AdminId");
            AddForeignKey("dbo.Rooms", "AdminId", "dbo.Admins", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "AdminId", "dbo.Admins");
            DropIndex("dbo.Rooms", new[] { "AdminId" });
            DropColumn("dbo.Rooms", "AdminId");
            DropTable("dbo.Admins");
        }
    }
}
