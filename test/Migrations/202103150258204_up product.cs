namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upproduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "amout", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "barcode", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "desc", c => c.String());
            AddColumn("dbo.Products", "img", c => c.String());
            AddColumn("dbo.Products", "updateDay", c => c.String());
            AddColumn("dbo.Products", "price", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "wholesalePrice", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "importPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "costPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "tax", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "tax");
            DropColumn("dbo.Products", "costPrice");
            DropColumn("dbo.Products", "importPrice");
            DropColumn("dbo.Products", "wholesalePrice");
            DropColumn("dbo.Products", "price");
            DropColumn("dbo.Products", "updateDay");
            DropColumn("dbo.Products", "img");
            DropColumn("dbo.Products", "desc");
            DropColumn("dbo.Products", "barcode");
            DropColumn("dbo.Products", "amout");
        }
    }
}
