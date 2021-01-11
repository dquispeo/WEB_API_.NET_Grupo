namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        facturaID = c.Int(nullable: false, identity: true),
                        numeroFactura = c.Int(nullable: false),
                        fechaFactura = c.DateTime(nullable: false),
                        nombreVendedor = c.String(nullable: false),
                        nombreCliente = c.String(nullable: false),
                        subTotal = c.Double(nullable: false),
                        IGV = c.Double(nullable: false),
                        total = c.Double(nullable: false),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.facturaID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        productoID = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false),
                        precio = c.Double(nullable: false),
                        stok = c.Int(nullable: false),
                        enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.productoID);
            
            CreateTable(
                "dbo.ProductoFacturas",
                c => new
                    {
                        Producto_productoID = c.Int(nullable: false),
                        Factura_facturaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_productoID, t.Factura_facturaID })
                .ForeignKey("dbo.Productoes", t => t.Producto_productoID, cascadeDelete: true)
                .ForeignKey("dbo.Facturas", t => t.Factura_facturaID, cascadeDelete: true)
                .Index(t => t.Producto_productoID)
                .Index(t => t.Factura_facturaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductoFacturas", "Factura_facturaID", "dbo.Facturas");
            DropForeignKey("dbo.ProductoFacturas", "Producto_productoID", "dbo.Productoes");
            DropIndex("dbo.ProductoFacturas", new[] { "Factura_facturaID" });
            DropIndex("dbo.ProductoFacturas", new[] { "Producto_productoID" });
            DropTable("dbo.ProductoFacturas");
            DropTable("dbo.Productoes");
            DropTable("dbo.Facturas");
        }
    }
}
