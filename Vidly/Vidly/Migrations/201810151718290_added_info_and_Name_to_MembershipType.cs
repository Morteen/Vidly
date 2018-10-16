namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_info_and_Name_to_MembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Info");
        }
    }
}
