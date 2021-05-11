namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFieldAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Admins", "AdminControlword", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Rooms", "Number", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Rooms", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Rooms", "Price", c => c.Int());
            AlterColumn("dbo.Rooms", "Number", c => c.String());
            AlterColumn("dbo.Admins", "AdminControlword", c => c.String());
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String());
            AlterColumn("dbo.Admins", "AdminName", c => c.String());
        }
    }
}
