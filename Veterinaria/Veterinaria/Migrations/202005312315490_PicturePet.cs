namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PicturePet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "Img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "Img");
        }
    }
}
