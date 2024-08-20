using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SEETEK_EMS_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB
{
    public class DBContext : DbContext
    {

        public DbSet<ResourceGroup> ResourceGroups { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public DbSet<RoutingMap> RoutingMaps { get; set; }

        public DbSet<ProductionOrder> ProductionOrders { get; set; }

        public DbSet<SN> SNs { get; set; }
        public DbSet<SNTracking> SNTrackings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ResourceGroup entity configuration
            modelBuilder.Entity<ResourceGroup>(entity =>
            {
                // Primary key
                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

                //// Relationships
                //entity.HasOne(e => e.Station)
                //      .WithOne(s => s.ResourceGroup)
                //      .HasForeignKey<Station>(s => s.ResourceGroupId);
                //      //.OnDelete(DeleteBehavior.Cascade); // If you want cascading delete

              
                
            });

            // Station entity configuration
            modelBuilder.Entity<Station>(entity =>
            {
                // Primary key
                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                     .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

                //entity.HasOne(e => e.ResourceGroup)
                //      .WithOne(r => r.Stations)
                //      .HasForeignKey(e => e.ResourceGroupId);

                // Relationships
                //entity.HasMany(e => e.Operations)
                //      .WithOne(o => o.Station)
                //      .HasForeignKey(o => o.StationID)
                //      .OnDelete(DeleteBehavior.Cascade); // If you want cascading delete


            });

            // Operation entity configuration
            modelBuilder.Entity<Operation>(entity =>
            {
                // Primary key
                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                     .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

                //// Relationships
                //entity.HasOne(e => e.Station)
                //      .WithMany(s => s.Operations)
                //      .HasForeignKey(e => e.StationID);
            });

            // Configure the relationships for RoutingMap
            modelBuilder.Entity<RoutingMap>(entity =>
            {
                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.Step)
                .IsRequired();

                entity.HasOne(e => e.ResourceGroup)
                .WithMany(r => r.RoutingMaps)
                .HasForeignKey(r => r.ResourceGroupID);


                entity.HasOne(e => e.Station)
               .WithMany(r => r.RoutingMaps)
               .HasForeignKey(r => r.StationID);
               //.OnDelete(DeleteBehavior;



                entity.HasOne(e => e.Operation)
               .WithMany(r => r.RoutingMaps)
               .HasForeignKey(r => r.OperationID);
               


                entity.HasMany(e => e.ProductionOrders)
                .WithOne(s => s.RoutingMap)
                .HasForeignKey(s => s.RoutingMapID);

            });


            modelBuilder.Entity<ProductionOrder>(entity =>
            {

                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                // Properties
                entity.Property(e => e.Partnumber)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                   .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.RoutingMap)
                .WithMany(s => s.ProductionOrders)
                .HasForeignKey(d => d.RoutingMapID);


                entity.HasMany(e => e.SNs)
                .WithOne(p => p.ProductionOrder)
                .HasForeignKey(e => e.ProductionOrderID); // inside SN

            });


            modelBuilder.Entity<SN>(entity =>
            {
                entity.HasKey(e => e.ID);

                // Properties
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.HasOne(p => p.ProductionOrder)
                 .WithMany(s => s.SNs)
                 .HasForeignKey(s => s.ProductionOrderID);

                entity.Property(e => e.UpdateDate)
                 .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");

            });


            modelBuilder.Entity<SNTracking>(entity => {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.SNName)
                     .IsRequired()
                     .HasMaxLength(100);

                entity.HasOne(e => e.SN)
                .WithMany()
                .HasForeignKey(e => e.SNID)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.RoutingMap)
                .WithMany()
                .HasForeignKey(e => e.RoutingMapID);
                //.HasForeignKey(e => e.RoutingMapStep);

                entity.Property(e => e.UpdateDate)
              .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.CreatedDate)
                      .HasDefaultValueSql("GETDATE()");


            });

        }

            

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .Build();

           
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
