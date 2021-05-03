namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "imgUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "imgUrl");
        }
    }
}
