using Microsoft.EntityFrameworkCore;
using OneRecord.Data.Model.Model;


namespace Tracking.Data
{
    public class TrackingDbContext : DbContext
    {
        public TrackingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ActivitySequence> ActivitySequence { get; set; }
        public DbSet<Booking> Booking { get; set; }

        public DbSet<Context> Context { get; set; }

        public DbSet<Dimensions> Dimensions { get; set; }


        public DbSet<Geolocation> Geolocation { get; set; }
        public DbSet<IotDevice> IotDevice { get; set; }

        public DbSet<Loading> Loading { get; set; }
        public DbSet<LoadingActivity> LoadingActivity { get; set; }

        public DbSet<Location> Location { get; set; }
        public DbSet<Measurement> Measurement { get; set; }
        public DbSet<MovementTimes> MovementTimes { get; set; }

        public DbSet<Piece> Piece { get; set; }

        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<TransportMeans> TransportMeans { get; set; }
        public DbSet<TransportMovement> TransportMovement { get; set; }
        public DbSet<Value> Value { get; set; }
        public DbSet<Waybill> Waybill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<EntityBase>();
            modelBuilder.Ignore<LogisticsObject>(); 
            modelBuilder.Ignore<LogisticsAction>();
            modelBuilder.Ignore<LogisticsActivity>();
            modelBuilder.Ignore<LogisticsService>();
            modelBuilder.Ignore<PhysicalLogisticsObject>();

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.IssuedForWaybill)
                .WithOne(w => w.ReferredBookingOption)
                .HasForeignKey<Waybill>(w => w.ReferredBookingOptionId); // Assuming ReferredBookingOptionId is the foreign key in Waybill


            modelBuilder.Entity<Shipment>()
                .HasOne(s => s.Waybill)
                .WithOne(w => w.Shipment)
                .HasForeignKey<Waybill>(w => w.ShipmentId); // Assuming ShipmentId is the foreign key in Waybill

                    modelBuilder.Entity<IotDevice>()
                .HasMany(d => d.ConnectedSensors)
                .WithOne(s => s.PartOfIotDevice)
                .HasForeignKey(s => s.IotDeviceId);

            modelBuilder.Entity<Context>().HasNoKey(); // Assuming Context is the entity type causing the error
            //modelBuilder.Entity<Revision>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
