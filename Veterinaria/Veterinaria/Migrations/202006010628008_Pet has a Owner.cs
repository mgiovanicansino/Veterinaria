namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PethasaOwner : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pets", new[] { "Owner_Id" });
            CreateIndex("dbo.Pets", "owner_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pets", new[] { "owner_Id" });
            CreateIndex("dbo.Pets", "Owner_Id");
        }
    }
}
