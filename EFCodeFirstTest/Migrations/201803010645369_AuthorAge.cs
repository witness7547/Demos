namespace EFCodeFirstTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Age", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Age");
        }
    }
}
