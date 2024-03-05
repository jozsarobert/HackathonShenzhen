using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.Model;

namespace Tracking.Data
{
    public class TrackingDbContext : DbContext
    {
        public TrackingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AccessDelegation> AccessDelegation { get; set; }
        //public DbSet<AccessDelegationRequest> AccessDelegationRequest { get; set; }
        public DbSet<AccessPermissions> AccessPermissions { get; set; }
        public DbSet<ActivitySequence> ActivitySequence { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Adjustments> Adjustments { get; set; }
        public DbSet<Answer> Answer { get; set; }
        //public DbSet<AuditTrail> AuditTrail { get; set; }
        public DbSet<BillingDetails> BillingDetails { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingOption> BookingOption { get; set; }
        public DbSet<BookingOptionRequest> BookingOptionRequest { get; set; }
        public DbSet<BookingRequest> BookingRequest { get; set; }
        public DbSet<BookingShipment> BookingShipment { get; set; }
        public DbSet<BookingTimes> BookingTimes { get; set; }
        public DbSet<Carrier> Carrier { get; set; }
        public DbSet<CarrierProduct> CarrierProduct { get; set; }
        //public DbSet<Change> Change { get; set; }
        //public DbSet<ChangeRequest> ChangeRequest { get; set; }
        public DbSet<Characteristic> Characteristic { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<CheckTemplate> CheckTemplate { get; set; }
        public DbSet<CheckTotalResult> CheckTotalResult { get; set; }
        public DbSet<Co2Emissions> CO2Emissions { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Composing> Composing { get; set; }
        public DbSet<ContactDetail> ContactDetail { get; set; }
        public DbSet<Context> Context { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CustomsInformation> CustomsInformation { get; set; }
        public DbSet<DgDeclaration> DgDeclaration { get; set; }
        public DbSet<DgProductRadioactive> DgProductRadioactive { get; set; }
        public DbSet<DgRadioactiveIsotope> DgRadioactiveIsotope { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        //public DbSet<EntityBase> EntityBase { get; set; }
        public DbSet<EpermitConsignment> EpermitConsignment { get; set; }
        public DbSet<EpermitSignature> EpermitSignature { get; set; }
        public DbSet<Error> Error { get; set; }
        public DbSet<ErrorDetail> ErrorDetail { get; set; }
        public DbSet<ExternalReference> ExternalReference { get; set; }
        public DbSet<Geolocation> Geolocation { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<IotDevice> IotDevice { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemDg> ItemDg { get; set; }
        public DbSet<LiveAnimalsEpermit> LiveAnimalsEpermit { get; set; }
        public DbSet<Loading> Loading { get; set; }
        public DbSet<LoadingActivity> LoadingActivity { get; set; }
        public DbSet<LoadingMaterial> LoadingMaterial { get; set; }
        public DbSet<LoadingUnit> LoadingUnit { get; set; }
        public DbSet<Location> Location { get; set; }
        //public DbSet<LogisticsAction> LogisticsAction { get; set; }
        //public DbSet<LogisticsActivity> LogisticsActivity { get; set; }
        //public DbSet<LogisticsAgent> LogisticsAgent { get; set; }
        //public DbSet<LogisticsEvent> LogisticsEvent { get; set; }
        public DbSet<LogisticsEventCollection> LogisticsEventCollection { get; set; }
        //public DbSet<LogisticsObject> LogisticsObject { get; set; }
        //public DbSet<LogisticsService> LogisticsService { get; set; }
        public DbSet<Measurement> Measurement { get; set; }
        public DbSet<MovementTimes> MovementTimes { get; set; }
        public DbSet<Moving> Moving { get; set; }
        public DbSet<NonHumanActor> NonHumanActor { get; set; }
        //public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationEventType> NotificationEventType { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<OperationObject> OperationObject { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<OtherIdentifier> OtherIdentifier { get; set; }
        public DbSet<PackagingType> PackagingType { get; set; }
        public DbSet<Party> Party { get; set; }
        public DbSet<PatchOperation> PatchOperation { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Person> Person { get; set; }
        //public DbSet<PhysicalLogisticsObject> PhysicalLogisticsObject { get; set; }
        public DbSet<Piece> Piece { get; set; }
        public DbSet<PieceDg> PieceDg { get; set; }
        public DbSet<PieceLiveAnimals> PieceLiveAnimals { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDg> ProductDg { get; set; }
        public DbSet<PublicAuthority> PublicAuthority { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Ranges> Ranges { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<RegulatedEntity> RegulatedEntity { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        //public DbSet<Revision> Revision { get; set; }
        public DbSet<Routing> Routing { get; set; }
        public DbSet<ScheduledLegs> ScheduledLegs { get; set; }
        public DbSet<SecurityDeclaration> SecurityDeclaration { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Storing> Storing { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        //public DbSet<SubscriptionRequest> SubscriptionRequest { get; set; }
        public DbSet<TopicType> TopicType { get; set; }
        public DbSet<TransportLegs> TransportLegs { get; set; }
        public DbSet<TransportMeans> TransportMeans { get; set; }
        public DbSet<TransportMovement> TransportMovement { get; set; }
        public DbSet<ULD> ULD { get; set; }
        public DbSet<UnitComposition> UnitComposition { get; set; }
        public DbSet<Value> Value { get; set; }
        public DbSet<VolumetricWeight> VolumetricWeight { get; set; }
        public DbSet<Waybill> Waybill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<EntityBase>();
            modelBuilder.Ignore<LogisticsObject>(); 
            modelBuilder.Ignore<LogisticsEvent>(); 
            modelBuilder.Ignore<LogisticsAction>();
            modelBuilder.Ignore<LogisticsActivity>();
            modelBuilder.Ignore<LogisticsService>();
            modelBuilder.Ignore<PhysicalLogisticsObject>();

            // Configure the one-to-one relationship between Answer and Question
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithOne(q => q.Answer)
                .HasForeignKey<Question>(q => q.AnswerId); // Assuming AnswerId is the foreign key in Question

            modelBuilder.Entity<BillingDetails>()
                .HasOne(b => b.DetailedWaybill)
                .WithOne(w => w.BillingDetails)
                .HasForeignKey<Waybill>(w => w.BillingDetailsId); // Assuming BillingDetailsId is the foreign key in Waybill

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.ForBookingRequest)
                .WithOne(br => br.Booking)
                .HasForeignKey<Booking>(b => b.BookingRequestId); // Assuming BookingRequestId is the foreign key in Booking

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.IssuedForWaybill)
                .WithOne(w => w.ReferredBookingOption)
                .HasForeignKey<Waybill>(w => w.ReferredBookingOptionId); // Assuming ReferredBookingOptionId is the foreign key in Waybill

            modelBuilder.Entity<BookingOption>()
                .HasOne(bo => bo.BookingTimes)
                .WithOne(bt => bt.ForBookingOptions)
                .HasForeignKey<BookingTimes>(bt => bt.BookingOptionId); // Assuming BookingOptionId is the foreign key in BookingTimes

            modelBuilder.Entity<BookingOption>()
                .HasOne(bo => bo.ForBookingRequest)
                .WithOne(br => br.BookingOption)
                .HasForeignKey<BookingOption>(bo => bo.BookingRequestId); // Assuming BookingRequestId is the foreign key in BookingOption

            modelBuilder.Entity<BookingOption>()
               .HasOne(bo => bo.Price)
               .WithOne(p => p.ForBookingOptions)
               .HasForeignKey<Price>(p => p.BookingOptionId); // Assuming BookingOptionId is the foreign key in Price

            modelBuilder.Entity<BookingOption>()
                .HasOne(bo => bo.Routing)
                .WithOne(r => r.ForBookingOptions)
                .HasForeignKey<Routing>(r => r.BookingOptionId); // Assuming BookingOptionId is the foreign key in Routing

            modelBuilder.Entity<BookingOptionRequest>()
                .HasOne(bor => bor.RoutingPreference)
                .WithOne(r => r.ForBookingOptionRequest)
                .HasForeignKey<Routing>(r => r.BookingOptionRequestId); // Assuming BookingOptionRequestId is the foreign key in Routing

            modelBuilder.Entity<BookingOptionRequest>()
                .HasOne(bor => bor.TimePreferences)
                .WithOne(bt => bt.ForBookingOptionRequest)
                .HasForeignKey<BookingTimes>(bt => bt.BookingOptionRequestId); // Assuming BookingOptionRequestId is the foreign key in BookingTimes


            modelBuilder.Entity<DgProductRadioactive>()
                .HasOne(dg => dg.ForProductDg)
                .WithOne(pd => pd.DgRadioactiveMaterial)
                .HasForeignKey<ProductDg>(pd => pd.DgProductRadioactiveId); // Assuming DgProductRadioactiveId is the foreign key in ProductDg

            modelBuilder.Entity<EpermitConsignment>()
                .HasOne(ec => ec.ConsignmentItems)
                .WithOne(pla => pla.AssociatedEpermit)
                .HasForeignKey<PieceLiveAnimals>(pla => pla.EpermitConsignmentId); // Assuming EpermitConsignmentId is the foreign key in PieceLiveAnimals

            modelBuilder.Entity<Organization>()
                .HasOne(o => o.BasedAtLocation)
                .WithOne(l => l.TransportOrganization)
                .HasForeignKey<Location>(l => l.OrganizationId); // Assuming OrganizationId is the foreign key in Location

            modelBuilder.Entity<Piece>()
                .HasOne(p => p.SecurityDeclaration)
                .WithOne(sd => sd.IssuedForPiece)
                .HasForeignKey<SecurityDeclaration>(sd => sd.PieceId); // Assuming PieceId is the foreign key in SecurityDeclaration


            modelBuilder.Entity<Shipment>()
                .HasOne(s => s.Insurance)
                .WithOne(i => i.InsuredShipment)
                .HasForeignKey<Insurance>(i => i.ShipmentId); // Assuming ShipmentId is the foreign key in Insurance

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
