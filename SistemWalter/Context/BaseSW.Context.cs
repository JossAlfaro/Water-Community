﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemWalter.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemadeAguaEntities : DbContext
    {
        public SistemadeAguaEntities()
            : base("name=SistemadeAguaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Configuracione> Configuraciones { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Inscripcione> Inscripciones { get; set; }
        public virtual DbSet<Lectura> Lecturas { get; set; }
        public virtual DbSet<MoraCliente> MoraClientes { get; set; }
        public virtual DbSet<PagoInscripcion> PagoInscripcions { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Fechas> Tbl_Fechas { get; set; }
    }
}
