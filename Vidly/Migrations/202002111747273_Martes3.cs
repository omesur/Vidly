namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Martes3 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Costumers");
            Sql("INSERT INTO Customers (Id,Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (1,'Juan2', 'False', 2)");
            Sql("INSERT INTO Customers (Id,Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (2,'Juan3', 'False', 3)");
            Sql("INSERT INTO Customers (Id,Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (3,'Juan4', 'False', 4)");
            Sql("INSERT INTO Customers (Id,Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (4,'Juan5', 'False', 2)");
        }

        public override void Down()
        {
        }
    }
}
