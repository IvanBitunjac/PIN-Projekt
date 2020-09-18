namespace PIN_Projekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameValidation2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proizvods", "Description", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proizvods", "Description", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
