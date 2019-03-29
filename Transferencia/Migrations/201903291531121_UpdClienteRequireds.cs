namespace Transferencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdClienteRequireds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Identificacion", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Identificacion", c => c.String(maxLength: 30));
        }
    }
}
