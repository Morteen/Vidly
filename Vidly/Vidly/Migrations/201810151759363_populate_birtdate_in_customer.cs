namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_birtdate_in_customer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '28-jan-1973' WHERE Id=1");
            Sql("UPDATE Customers SET Birthdate = '12-mar-2013' WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
