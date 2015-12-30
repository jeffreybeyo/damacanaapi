namespace damacanaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.Products", "Purchase_Id", "dbo.Purchases");
            DropIndex("dbo.Products", new[] { "Cart_Id" });
            DropIndex("dbo.Products", new[] { "Purchase_Id" });
            DropPrimaryKey("dbo.Carts");
            DropPrimaryKey("dbo.Purchases");
            CreateTable(
                "dbo.CartDTOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Carts", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Carts", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Purchases", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Carts", "Id");
            AddPrimaryKey("dbo.Purchases", "Id");
            DropColumn("dbo.Products", "Cart_Id");
            DropColumn("dbo.Products", "Purchase_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Purchase_Id", c => c.Int());
            AddColumn("dbo.Products", "Cart_Id", c => c.Int());
            DropPrimaryKey("dbo.Purchases");
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Purchases", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Carts", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Carts", "CreatedOn");
            DropTable("dbo.CartDTOes");
            AddPrimaryKey("dbo.Purchases", "Id");
            AddPrimaryKey("dbo.Carts", "Id");
            CreateIndex("dbo.Products", "Purchase_Id");
            CreateIndex("dbo.Products", "Cart_Id");
            AddForeignKey("dbo.Products", "Purchase_Id", "dbo.Purchases", "Id");
            AddForeignKey("dbo.Products", "Cart_Id", "dbo.Carts", "Id");
        }
    }
}
