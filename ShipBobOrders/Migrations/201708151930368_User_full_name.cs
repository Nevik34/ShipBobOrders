namespace ShipBobOrders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_full_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "LastName", c => c.String());
            AlterColumn("dbo.User", "FirstName", c => c.String());
        }
    }
}
