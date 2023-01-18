namespace Practicas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Curso = c.String(),
                        IdProfesor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profesors", t => t.IdProfesor, cascadeDelete: true)
                .Index(t => t.IdProfesor);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "IdProfesor", "dbo.Profesors");
            DropIndex("dbo.Alumno", new[] { "IdProfesor" });
            DropTable("dbo.Profesors");
            DropTable("dbo.Alumno");
        }
    }
}
