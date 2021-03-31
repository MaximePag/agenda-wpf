using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AgendaWPF
{
    public partial class AgendaContext : DbContext
    {
        public AgendaContext()
            : base("name=agendaWPF")
        {
        }

        public virtual DbSet<af458_appointments> af458_appointments { get; set; }
        public virtual DbSet<af458_brokers> af458_brokers { get; set; }
        public virtual DbSet<af458_customers> af458_customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<af458_appointments>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<af458_brokers>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<af458_brokers>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<af458_brokers>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<af458_brokers>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<af458_brokers>()
                .HasMany(e => e.af458_appointments)
                .WithRequired(e => e.af458_brokers)
                .HasForeignKey(e => e.id_af458_brokers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<af458_brokers>()
                .HasMany(e => e.af458_customers)
                .WithRequired(e => e.af458_brokers)
                .HasForeignKey(e => e.id_af458_brokers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<af458_customers>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<af458_customers>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<af458_customers>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<af458_customers>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<af458_customers>()
                .HasMany(e => e.af458_appointments)
                .WithRequired(e => e.af458_customers)
                .HasForeignKey(e => e.id_af458_customers)
                .WillCascadeOnDelete(false);
        }
    }
}
