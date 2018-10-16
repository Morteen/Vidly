namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_info_and_Name_to_MembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Info ='Pay onley when you enter', Name = 'Pay as you go' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Info ='Monthly based subs', Name = 'Monthly' WHERE Id=2");
            Sql("UPDATE MembershipTypes SET Info ='Quarterly based subs', Name = 'Quarterly' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET Info ='Yearly based subs', Name = 'Yearly' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
