namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddatestouser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DateFrom", c => c.String());
            AddColumn("dbo.Users", "DateTo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DateTo");
            DropColumn("dbo.Users", "DateFrom");
        }
    }
}
