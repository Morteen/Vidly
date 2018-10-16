namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_IsSubscribed_To_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
