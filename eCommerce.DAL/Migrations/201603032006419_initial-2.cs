namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BasketItems", "Quantity");
            DropColumn("dbo.OrderItems", "Description");
            DropColumn("dbo.OrderItems", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "ImageUrl", c => c.String(maxLength: 255));
            AddColumn("dbo.OrderItems", "Description", c => c.String());
            AddColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
        }
    }
}
