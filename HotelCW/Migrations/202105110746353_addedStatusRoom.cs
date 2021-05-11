namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedStatusRoom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "Status");
        }
    }
}
