﻿using System;
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
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaybillPrefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingRequestId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Api = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vocab = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    GeolocationElevationValue = table.Column<double>(type: "float", nullable: false),
                    GeolocationElevationUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeolocationUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    TotalGrossWeightValue = table.Column<double>(type: "float", nullable: false),
                    TotalGrossWeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Incoterms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialHandlingCodes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextualHandlingInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportMeans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMeans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivitySequence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SequenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeolocationId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Geolocation_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeightValue = table.Column<double>(type: "float", nullable: false),
                    HeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LenghtValue = table.Column<double>(type: "float", nullable: false),
                    LengthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeValue = table.Column<double>(type: "float", nullable: false),
                    VolumeUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WidthValue = table.Column<double>(type: "float", nullable: false),
                    WidthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "TransportMovement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArrivalLocationId = table.Column<int>(type: "int", nullable: false),
                    DepartureLocationId = table.Column<int>(type: "int", nullable: false),
                    OperatingTransportMeansId = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeQualifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMovement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportMovement_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportMovement_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportMovement_TransportMeans_OperatingTransportMeansId",
                        column: x => x.OperatingTransportMeansId,
                        principalTable: "TransportMeans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waybill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferredBookingOptionId = table.Column<int>(type: "int", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    ArrivalLocationId = table.Column<int>(type: "int", nullable: false),
                    DepartureLocationId = table.Column<int>(type: "int", nullable: false),
                    WaybillType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherChargesIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightValueIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomsOriginCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountingInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierDeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarrierDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsignorDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationCurrencyRate = table.Column<double>(type: "float", nullable: false),
                    ShippingInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingRefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaybillPrefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModularCheckNumber = table.Column<bool>(type: "bit", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Waybill_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Waybill_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnTransportMeansId = table.Column<int>(type: "int", nullable: false),
                    LoadingPositionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportMovementId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loading_TransportMeans_OnTransportMeansId",
                        column: x => x.OnTransportMeansId,
                        principalTable: "TransportMeans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loading_TransportMovement_TransportMovementId",
                        column: x => x.TransportMovementId,
                        principalTable: "TransportMovement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovementTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementMilestone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementTimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportMovementId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementTimes_TransportMovement_TransportMovementId",
                        column: x => x.TransportMovementId,
                        principalTable: "TransportMovement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Piece",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentProductionCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DimensionsId = table.Column<int>(type: "int", nullable: false),
                    GrossWeightValue = table.Column<double>(type: "float", nullable: false),
                    GrossWeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfShipmentId = table.Column<int>(type: "int", nullable: false),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FulfillsUldTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageMarkCoded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialHandlingCodes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coload = table.Column<bool>(type: "bit", nullable: false),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NvdForCarriage = table.Column<bool>(type: "bit", nullable: false),
                    NvdForCustoms = table.Column<bool>(type: "bit", nullable: false),
                    PackagedeIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingMarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slac = table.Column<int>(type: "int", nullable: false),
                    Stackable = table.Column<bool>(type: "bit", nullable: false),
                    TextualHandlingInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turnable = table.Column<bool>(type: "bit", nullable: false),
                    Upid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingId = table.Column<int>(type: "int", nullable: true),
                    PieceId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piece_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piece_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Shipment_OfShipmentId",
                        column: x => x.OfShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemperatureInstructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinTemperatureValue = table.Column<double>(type: "float", nullable: false),
                    MinTemperatureUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTemperatureValue = table.Column<double>(type: "float", nullable: false),
                    MaxTemperatureUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PieceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureInstructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemperatureInstructions_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IotDevice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociatedObject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IotDeviceId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    PieceId = table.Column<int>(type: "int", nullable: true),
                    SensorId = table.Column<int>(type: "int", nullable: true),
                    TransportMeansId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IotDevice_IotDevice_IotDeviceId",
                        column: x => x.IotDeviceId,
                        principalTable: "IotDevice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IotDevice_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IotDevice_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IotDevice_TransportMeans_TransportMeansId",
                        column: x => x.TransportMeansId,
                        principalTable: "TransportMeans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SensorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IotDeviceId = table.Column<int>(type: "int", nullable: false),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sensor_IotDevice_IotDeviceId",
                        column: x => x.IotDeviceId,
                        principalTable: "IotDevice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementValue = table.Column<double>(type: "float", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordedGeolocationId = table.Column<int>(type: "int", nullable: false),
                    MeasurementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensorId = table.Column<int>(type: "int", nullable: true),
                    NeonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                        name: "FK_Measurement_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySequence_BookingId",
                table: "ActivitySequence",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_IotDeviceId",
                table: "IotDevice",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_LocationId",
                table: "IotDevice",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_PieceId",
                table: "IotDevice",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_SensorId",
                table: "IotDevice",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_TransportMeansId",
                table: "IotDevice",
                column: "TransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_OnTransportMeansId",
                table: "Loading",
                column: "OnTransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_TransportMovementId",
                table: "Loading",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_GeolocationId",
                table: "Location",
                column: "GeolocationId");

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
                name: "IX_Piece_DimensionsId",
                table: "Piece",
                column: "DimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_LoadingId",
                table: "Piece",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_OfShipmentId",
                table: "Piece",
                column: "OfShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_PieceId",
                table: "Piece",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_IotDeviceId",
                table: "Sensor",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureInstructions_PieceId",
                table: "TemperatureInstructions",
                column: "PieceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_ArrivalLocationId",
                table: "TransportMovement",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_DepartureLocationId",
                table: "TransportMovement",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_OperatingTransportMeansId",
                table: "TransportMovement",
                column: "OperatingTransportMeansId");

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
                name: "FK_IotDevice_Sensor_SensorId",
                table: "IotDevice",
                column: "SensorId",
                principalTable: "Sensor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipment_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Shipment_OfShipmentId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_Location_LocationId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Location_ArrivalLocationId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Location_DepartureLocationId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_Piece_PieceId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_Sensor_SensorId",
                table: "IotDevice");

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
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Geolocation");

            migrationBuilder.DropTable(
                name: "Piece");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Loading");

            migrationBuilder.DropTable(
                name: "TransportMovement");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "IotDevice");

            migrationBuilder.DropTable(
                name: "TransportMeans");
        }
    }
}
