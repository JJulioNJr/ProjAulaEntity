namespace AulaEF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonMobileEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Mobile");
            DropColumn("dbo.People", "Email");
        }
    }
}
