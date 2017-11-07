namespace inso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPregunta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pregunta",
                c => new
                    {
                        PreguntaId = c.Int(nullable: false, identity: true),
                        pregunta = c.String(nullable: false, maxLength: 200),
                        opt1 = c.String(nullable: false, maxLength: 200),
                        opt2 = c.String(nullable: false, maxLength: 200),
                        opt3 = c.String(nullable: false, maxLength: 200),
                        opt4 = c.String(nullable: false, maxLength: 200),
                        contador = c.String(),
                    })
                .PrimaryKey(t => t.PreguntaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pregunta");
        }
    }
}
