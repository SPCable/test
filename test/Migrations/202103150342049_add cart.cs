namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        idCart = c.String(nullable: false, maxLength: 128),
                        idProduct = c.String(),
                        idCount = c.String(),
                    })
                .PrimaryKey(t => t.idCart);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carts");
        }
    }
}
