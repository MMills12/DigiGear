namespace TrainingWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        SyllabusId = c.Int(nullable: false, identity: true),
                        Week = c.Int(nullable: false),
                        Topic = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SyllabusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Schedules");
        }
    }
}
