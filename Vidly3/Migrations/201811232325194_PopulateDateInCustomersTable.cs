namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateInCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers set Date = (CASE WHEN Id = 1 THEN '1/1/1980' END);");
        }
        
        public override void Down()
        {

        }
    }
}


