namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNullToRoomID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Users", new[] { "RoomId" });
            AlterColumn("dbo.Users", "RoomId", c => c.Int());
            CreateIndex("dbo.Users", "RoomId");
            AddForeignKey("dbo.Users", "RoomId", "dbo.Rooms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Users", new[] { "RoomId" });
            AlterColumn("dbo.Users", "RoomId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "RoomId");
            AddForeignKey("dbo.Users", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
        }
    }
}
