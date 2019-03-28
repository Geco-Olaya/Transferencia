namespace Transferencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionCantidadCaracCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(maxLength: 200));
            AlterColumn("dbo.Clientes", "Identificacion", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Identificacion", c => c.String());
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
        }
    }
}
