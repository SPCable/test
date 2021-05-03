namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addorder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        idCustomer = c.String(),
                        idCart = c.String(),
                        dateTime = c.String(),
                        transportFee = c.Double(nullable: false),
                        totalOrder = c.Double(nullable: false),
                        totalCost = c.Double(nullable: false),
                        discout = c.Double(nullable: false),
                        statusPay = c.Int(nullable: false),
                        statusOrder = c.Int(nullable: false),
                        payMethod = c.Int(nullable: false),
                        amout = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
