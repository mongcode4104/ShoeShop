namespace ShoeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEditProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 500));
            DropColumn("dbo.Products", "Desription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desription", c => c.String(maxLength: 500));
            DropColumn("dbo.Products", "Description");
        }
    }
}
