namespace Transferencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionRequeridoNombreCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(maxLength: 200));
        }
    }
}
