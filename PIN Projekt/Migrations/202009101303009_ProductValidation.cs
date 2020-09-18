namespace PIN_Projekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proizvods", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Proizvods", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proizvods", "Description", c => c.String());
            AlterColumn("dbo.Proizvods", "Name", c => c.String());
        }
    }
}
