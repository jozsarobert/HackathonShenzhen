using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracking.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Context",
                columns: table => new
                {
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Api = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vocab = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Geolocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeolocationElevationValue = table.Column<double>(type: "float", nullable: true),
                    GeolocationElevationUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeolocationUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalGrossWeightValue = table.Column<double>(type: "float", nullable: true),
                    TotalGrossWeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialHandlingCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextualHandlingInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeightValue = table.Column<double>(type: "float", nullable: true),
                    HeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LenghtValue = table.Column<double>(type: "float", nullable: true),
                    LengthUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumeValue = table.Column<double>(type: "float", nullable: true),
                    VolumeUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthValue = table.Column<double>(type: "float", nullable: true),
                    WidthUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivitySequence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    SequenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitySequence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitySequence_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Loading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnTransportMeansId = table.Column<int>(type: "int", nullable: true),
                    LoadingPositionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportMovementId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ServedActivityId = table.Column<int>(type: "int", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loading", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalLogisticsObject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false),
                    AttachedToObjectId = table.Column<int>(type: "int", nullable: true),
                    AssociatedObject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLogisticsObjectId = table.Column<int>(type: "int", nullable: true),
                    GeolocationId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentProductionCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DimensionsId = table.Column<int>(type: "int", nullable: true),
                    GrossWeightValue = table.Column<double>(type: "float", nullable: true),
                    GrossWeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfShipmentId = table.Column<int>(type: "int", nullable: true),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FulfillsUldTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageMarkCoded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialHandlingCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coload = table.Column<bool>(type: "bit", nullable: true),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NvdForCarriage = table.Column<bool>(type: "bit", nullable: true),
                    NvdForCustoms = table.Column<bool>(type: "bit", nullable: true),
                    PackagedeIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slac = table.Column<int>(type: "int", nullable: true),
                    Stackable = table.Column<bool>(type: "bit", nullable: true),
                    Turnable = table.Column<bool>(type: "bit", nullable: true),
                    Upid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingId = table.Column<int>(type: "int", nullable: true),
                    PieceId = table.Column<int>(type: "int", nullable: true),
                    Sensor_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sensor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SensorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sensor_SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IotDeviceId = table.Column<int>(type: "int", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalLogisticsObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_Geolocation_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_PhysicalLogisticsObject_AttachedToObjectId",
                        column: x => x.AttachedToObjectId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_PhysicalLogisticsObject_IotDeviceId",
                        column: x => x.IotDeviceId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_PhysicalLogisticsObject_PhysicalLogisticsObjectId",
                        column: x => x.PhysicalLogisticsObjectId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_PhysicalLogisticsObject_PieceId",
                        column: x => x.PieceId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhysicalLogisticsObject_Shipment_OfShipmentId",
                        column: x => x.OfShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LogisticsActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    ArrivalLocationId = table.Column<int>(type: "int", nullable: true),
                    DepartureLocationId = table.Column<int>(type: "int", nullable: true),
                    OperatingTransportMeansId = table.Column<int>(type: "int", nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeQualifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogisticsActivity_PhysicalLogisticsObject_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsActivity_PhysicalLogisticsObject_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogisticsActivity_PhysicalLogisticsObject_OperatingTransportMeansId",
                        column: x => x.OperatingTransportMeansId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Measurement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementValue = table.Column<double>(type: "float", nullable: true),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordedGeolocationId = table.Column<int>(type: "int", nullable: true),
                    MeasurementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensorId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurement_Geolocation_RecordedGeolocationId",
                        column: x => x.RecordedGeolocationId,
                        principalTable: "Geolocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Measurement_PhysicalLogisticsObject_SensorId",
                        column: x => x.SensorId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TemperatureInstructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinTemperatureValue = table.Column<double>(type: "float", nullable: true),
                    MinTemperatureUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxTemperatureValue = table.Column<double>(type: "float", nullable: true),
                    MaxTemperatureUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PieceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureInstructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemperatureInstructions_PhysicalLogisticsObject_PieceId",
                        column: x => x.PieceId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waybill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferredBookingOptionId = table.Column<int>(type: "int", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    ArrivalLocationId = table.Column<int>(type: "int", nullable: true),
                    DepartureLocationId = table.Column<int>(type: "int", nullable: true),
                    WaybillType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargesIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightValueIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomsOriginCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierDeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarrierDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsignorDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCurrencyRate = table.Column<double>(type: "float", nullable: false),
                    ShippingInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModularCheckNumber = table.Column<bool>(type: "bit", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waybill_Booking_ReferredBookingOptionId",
                        column: x => x.ReferredBookingOptionId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Waybill_PhysicalLogisticsObject_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_PhysicalLogisticsObject_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "PhysicalLogisticsObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovementTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementMilestone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportMovementId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementTimes_LogisticsActivity_TransportMovementId",
                        column: x => x.TransportMovementId,
                        principalTable: "LogisticsActivity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySequence_ActivityId",
                table: "ActivitySequence",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySequence_BookingId",
                table: "ActivitySequence",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_OnTransportMeansId",
                table: "Loading",
                column: "OnTransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_ServedActivityId",
                table: "Loading",
                column: "ServedActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_TransportMovementId",
                table: "Loading",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsActivity_ArrivalLocationId",
                table: "LogisticsActivity",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsActivity_DepartureLocationId",
                table: "LogisticsActivity",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsActivity_OperatingTransportMeansId",
                table: "LogisticsActivity",
                column: "OperatingTransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurement_RecordedGeolocationId",
                table: "Measurement",
                column: "RecordedGeolocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurement_SensorId",
                table: "Measurement",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementTimes_TransportMovementId",
                table: "MovementTimes",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_AttachedToObjectId",
                table: "PhysicalLogisticsObject",
                column: "AttachedToObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_DimensionsId",
                table: "PhysicalLogisticsObject",
                column: "DimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_GeolocationId",
                table: "PhysicalLogisticsObject",
                column: "GeolocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_IotDeviceId",
                table: "PhysicalLogisticsObject",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_LoadingId",
                table: "PhysicalLogisticsObject",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_OfShipmentId",
                table: "PhysicalLogisticsObject",
                column: "OfShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_PhysicalLogisticsObjectId",
                table: "PhysicalLogisticsObject",
                column: "PhysicalLogisticsObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalLogisticsObject_PieceId",
                table: "PhysicalLogisticsObject",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureInstructions_PieceId",
                table: "TemperatureInstructions",
                column: "PieceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ArrivalLocationId",
                table: "Waybill",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_DepartureLocationId",
                table: "Waybill",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ReferredBookingOptionId",
                table: "Waybill",
                column: "ReferredBookingOptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ShipmentId",
                table: "Waybill",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitySequence_LogisticsActivity_ActivityId",
                table: "ActivitySequence",
                column: "ActivityId",
                principalTable: "LogisticsActivity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loading_LogisticsActivity_ServedActivityId",
                table: "Loading",
                column: "ServedActivityId",
                principalTable: "LogisticsActivity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loading_LogisticsActivity_TransportMovementId",
                table: "Loading",
                column: "TransportMovementId",
                principalTable: "LogisticsActivity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loading_PhysicalLogisticsObject_OnTransportMeansId",
                table: "Loading",
                column: "OnTransportMeansId",
                principalTable: "PhysicalLogisticsObject",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loading_LogisticsActivity_ServedActivityId",
                table: "Loading");

            migrationBuilder.DropForeignKey(
                name: "FK_Loading_LogisticsActivity_TransportMovementId",
                table: "Loading");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipment_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalLogisticsObject_Shipment_OfShipmentId",
                table: "PhysicalLogisticsObject");

            migrationBuilder.DropForeignKey(
                name: "FK_Loading_PhysicalLogisticsObject_OnTransportMeansId",
                table: "Loading");

            migrationBuilder.DropTable(
                name: "ActivitySequence");

            migrationBuilder.DropTable(
                name: "Context");

            migrationBuilder.DropTable(
                name: "Measurement");

            migrationBuilder.DropTable(
                name: "MovementTimes");

            migrationBuilder.DropTable(
                name: "TemperatureInstructions");

            migrationBuilder.DropTable(
                name: "Waybill");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "LogisticsActivity");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "PhysicalLogisticsObject");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Geolocation");

            migrationBuilder.DropTable(
                name: "Loading");
        }
    }
}
