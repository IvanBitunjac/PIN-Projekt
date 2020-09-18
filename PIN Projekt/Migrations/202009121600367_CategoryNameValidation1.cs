namespace PIN_Projekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameValidation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proizvods", "Description", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proizvods", "Description", c => c.String(nullable: false));
        }
    }
}
