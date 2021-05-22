namespace HotelCW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedcomments : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "User_Id", newName: "UserMain_Id");
            RenameIndex(table: "dbo.Comments", name: "IX_User_Id", newName: "IX_UserMain_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Comments", name: "IX_UserMain_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Comments", name: "UserMain_Id", newName: "User_Id");
        }
    }
}
