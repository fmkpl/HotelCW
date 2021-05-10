namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDaysInHotel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DaysInHotel", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DaysInHotel");
        }
    }
}
