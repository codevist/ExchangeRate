namespace codevist.ExchangeRate.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablesAndRelationShip : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        CurrencyCode = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        CurrencySymbol = c.String(maxLength: 20),
                        CurrencyName = c.String(nullable: false, maxLength: 75),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CurrencyCode);
            
            CreateTable(
                "dbo.ExchangeRateHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.Int(nullable: false),
                        ChangeRate = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Name = c.String(),
                        FullName = c.String(),
                        Buying = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Selling = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currency", t => t.CurrencyCode)
                .Index(t => t.CurrencyCode);
            
            CreateTable(
                "dbo.ExchangeRateData",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CurrencyCode = c.Int(nullable: false),
                        ChangeRate = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Name = c.String(),
                        FullName = c.String(),
                        Buying = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Selling = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currency", t => t.CurrencyCode)
                .Index(t => t.CurrencyCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExchangeRateData", "CurrencyCode", "dbo.Currency");
            DropForeignKey("dbo.ExchangeRateHistory", "CurrencyCode", "dbo.Currency");
            DropIndex("dbo.ExchangeRateData", new[] { "CurrencyCode" });
            DropIndex("dbo.ExchangeRateHistory", new[] { "CurrencyCode" });
            DropTable("dbo.ExchangeRateData");
            DropTable("dbo.ExchangeRateHistory");
            DropTable("dbo.Currency");
        }
    }
}
