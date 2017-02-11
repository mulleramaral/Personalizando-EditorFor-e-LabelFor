namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pessoas", "NomeMae");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "NomeMae", c => c.String());
        }
    }
}
