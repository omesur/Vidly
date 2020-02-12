namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreMovie2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Name) VALUES ('Action')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Infantil')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Drama')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
