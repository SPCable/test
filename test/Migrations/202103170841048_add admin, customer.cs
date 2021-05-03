namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadmincustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        user = c.String(),
                        pass = c.String(),
                        role = c.String(),
                        name = c.String(),
                        birth = c.String(),
                        sex = c.String(),
                        phone = c.String(),
                        mail = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        phone = c.String(),
                        mail = c.String(),
                        address = c.String(),
                        point = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
            DropTable("dbo.admins");
        }
    }
}
