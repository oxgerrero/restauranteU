using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


public class WELFAREContext : DbContext
{
    public WELFAREContext() : base("WELFARE")
    {

    }

    public DbSet<ESTADO> ESTADOs { get; set; }
    public DbSet<MENU> MENUs { get; set; }
    public DbSet<PAGO> PAGOs { get; set; }
    public DbSet<RESTAURANTE> RESTAURANTEs { get; set; }
    public DbSet<ROL> ROLs { get; set; }
    public DbSet<USUARIO> USUARIOs { get; set; }
    public static WELFAREContext Create()
    {
        return new WELFAREContext();
    }
}