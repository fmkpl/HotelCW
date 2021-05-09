namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roomType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "Type");
        }
    }
}
