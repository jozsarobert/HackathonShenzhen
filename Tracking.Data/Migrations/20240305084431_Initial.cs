using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracking.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessDelegation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifyRequestStatusChange = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessDelegation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingRequest",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarrierProduct",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceLevelCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrierProduct", x => x.Id);
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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DgProductRadioactive",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DgRaTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FissileExceptionIndicator = table.Column<bool>(type: "bit", nullable: false),
                    FissileExceptionReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportIndexNumeric = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgProductRadioactive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Error",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Error", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoadingActivity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoadingIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadingActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsEventCollection",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasTotalItem = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsEventCollection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationEventType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationEventType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PackagingType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatchOperation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatchOperation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillingChargeIdentifier = table.Column<double>(type: "float", nullable: false),
                    ChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargePaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entitlement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceSpecification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceSpecificationRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatingsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rcp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StoringIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopicType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitComposition",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompositionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitComposition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Value",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumericalValue = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Value", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_BookingRequest_BookingRequestId",
                        column: x => x.BookingRequestId,
                        principalTable: "BookingRequest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCodeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOfficeBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddressLines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DgRadioactiveIsotope",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContentOfDgProductRadioactiveId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActivityLevelMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalitySafetyIndexNumeric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsotopeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsotopeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowDispersibleIndicator = table.Column<bool>(type: "bit", nullable: false),
                    PhysicalChemicalForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialFormIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgRadioactiveIsotope", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DgRadioactiveIsotope_DgProductRadioactive_ContentOfDgProductRadioactiveId",
                        column: x => x.ContentOfDgProductRadioactiveId,
                        principalTable: "DgProductRadioactive",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ErrorDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasResource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErrorDetail_Error_ErrorId",
                        column: x => x.ErrorId,
                        principalTable: "Error",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatchOperationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Predicate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operation_PatchOperation_PatchOperationId",
                        column: x => x.PatchOperationId,
                        principalTable: "PatchOperation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ranges",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    MaximumQuantity = table.Column<double>(type: "float", nullable: false),
                    MinimumQuantity = table.Column<double>(type: "float", nullable: false),
                    RateClassCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatingsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ranges_Ratings_RatingsId",
                        column: x => x.RatingsId,
                        principalTable: "Ratings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TaxDueAgentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaxDueAirlineId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AwbAcceptanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AwbDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AwbExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AwbUseIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    CommissionIndicator = table.Column<bool>(type: "bit", nullable: false),
                    CommissionPercentage = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    ExchangeRate = table.Column<double>(type: "float", nullable: false),
                    NbCorrections = table.Column<int>(type: "int", nullable: false),
                    VatIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDetails_Value_TaxDueAgentId",
                        column: x => x.TaxDueAgentId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDetails_Value_TaxDueAirlineId",
                        column: x => x.TaxDueAirlineId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Geolocation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ElevationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GeolocationUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Geolocation_Value_ElevationId",
                        column: x => x.ElevationId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VolumetricWeight",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChargeableWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ConversionFactorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolumetricWeight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolumetricWeight_Value_ChargeableWeightId",
                        column: x => x.ChargeableWeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VolumetricWeight_Value_ConversionFactorId",
                        column: x => x.ConversionFactorId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivitySequence",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SequenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                name: "OperationObject",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasDatatype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationObject_Operation_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adjustments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CorrectionNumber = table.Column<int>(type: "int", nullable: false),
                    CorrectionSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonsForAdjustments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjustments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adjustments_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccessPermissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasLogisticsAgentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessDelegationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AccessPermissionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_AccessDelegation_AccessDelegationId",
                        column: x => x.AccessDelegationId,
                        principalTable: "AccessDelegation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Permission_AccessPermissions_AccessPermissionsId",
                        column: x => x.AccessPermissionsId,
                        principalTable: "AccessPermissions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnswerActorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnswerValueId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GivenAtLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Value_AnswerValueId",
                        column: x => x.AnswerValueId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingOption",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarrierProductInfoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FromCarrierId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RequestRefId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedWaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestMatchInd = table.Column<bool>(type: "bit", nullable: false),
                    ShipmentSecurityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingOption_BookingRequest_BookingRequestId",
                        column: x => x.BookingRequestId,
                        principalTable: "BookingRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingOption_CarrierProduct_CarrierProductInfoId",
                        column: x => x.CarrierProductInfoId,
                        principalTable: "CarrierProduct",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingOptionRequest",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingShipmentDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatingsPreferenceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitsPreferenceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Allotment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedCommodities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedHandling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentSecurityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingOptionRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingOptionRequest_Ratings_RatingsPreferenceId",
                        column: x => x.RatingsPreferenceId,
                        principalTable: "Ratings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingOptionRequest_Value_UnitsPreferenceId",
                        column: x => x.UnitsPreferenceId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingTimes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EarliestAcceptanceTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LatestAcceptanceTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LatestArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfAvailability = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalTransitTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingTimes_BookingOptionRequest_BookingOptionRequestId",
                        column: x => x.BookingOptionRequestId,
                        principalTable: "BookingOptionRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingTimes_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ForBookingOptionRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarrierChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrandTotal = table.Column<double>(type: "float", nullable: false),
                    ValidUntil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Price_BookingOptionRequest_ForBookingOptionRequestId",
                        column: x => x.ForBookingOptionRequestId,
                        principalTable: "BookingOptionRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Routing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AircraftPossibilityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxConnections = table.Column<int>(type: "int", nullable: false),
                    OnlineInd = table.Column<bool>(type: "bit", nullable: false),
                    FsInd = table.Column<bool>(type: "bit", nullable: false),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routing_BookingOptionRequest_BookingOptionRequestId",
                        column: x => x.BookingOptionRequestId,
                        principalTable: "BookingOptionRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Routing_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PriceRatings",
                columns: table => new
                {
                    ForPricesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RatingsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRatings", x => new { x.ForPricesId, x.RatingsId });
                    table.ForeignKey(
                        name: "FK_PriceRatings_Price_ForPricesId",
                        column: x => x.ForPricesId,
                        principalTable: "Price",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceRatings_Ratings_RatingsId",
                        column: x => x.RatingsId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingShipment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalDimensionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalGrossWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalVolumetricWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPieceCount = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingShipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingShipment_Value_TotalGrossWeightId",
                        column: x => x.TotalGrossWeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingShipment_VolumetricWeight_TotalVolumetricWeightId",
                        column: x => x.TotalVolumetricWeightId,
                        principalTable: "VolumetricWeight",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Characteristic",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OfProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CharacteristicType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Check",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckTotalResultId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsedTemplateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnswerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Co2EmissionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CustomsInformationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgProductRadioactiveId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgRadioactiveIsotopeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EpermitConsignmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EpermitSignatureId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsuranceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IotDeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LiveAnimalsEpermitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingUnitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PackagingTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PriceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatingsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoutingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SecurityDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoringId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportLegsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMeansId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitCompositionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WaybillId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    LocationOfPerformanceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_BookingOptionRequest_BookingOptionRequestId",
                        column: x => x.BookingOptionRequestId,
                        principalTable: "BookingOptionRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_BookingRequest_BookingRequestId",
                        column: x => x.BookingRequestId,
                        principalTable: "BookingRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_BookingShipment_BookingShipmentId",
                        column: x => x.BookingShipmentId,
                        principalTable: "BookingShipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Check_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Check",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_DgProductRadioactive_DgProductRadioactiveId",
                        column: x => x.DgProductRadioactiveId,
                        principalTable: "DgProductRadioactive",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_DgRadioactiveIsotope_DgRadioactiveIsotopeId",
                        column: x => x.DgRadioactiveIsotopeId,
                        principalTable: "DgRadioactiveIsotope",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_LoadingActivity_LoadingActivityId",
                        column: x => x.LoadingActivityId,
                        principalTable: "LoadingActivity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_PackagingType_PackagingTypeId",
                        column: x => x.PackagingTypeId,
                        principalTable: "PackagingType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Ratings_RatingsId",
                        column: x => x.RatingsId,
                        principalTable: "Ratings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Routing_RoutingId",
                        column: x => x.RoutingId,
                        principalTable: "Routing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Check_UnitComposition_UnitCompositionId",
                        column: x => x.UnitCompositionId,
                        principalTable: "UnitComposition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheckExternalReference",
                columns: table => new
                {
                    ChecksId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExternalReferencesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckExternalReference", x => new { x.ChecksId, x.ExternalReferencesId });
                    table.ForeignKey(
                        name: "FK_CheckExternalReference_Check_ChecksId",
                        column: x => x.ChecksId,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckTemplate",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LegacyTemplateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplatePurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckTemplateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnswerOptionsText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerOptionsValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionsNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionsSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_CheckTemplate_CheckTemplateId",
                        column: x => x.CheckTemplateId,
                        principalTable: "CheckTemplate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheckTotalResult",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CertifiedByActorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ResultValueId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passed = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckTotalResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckTotalResult_Value_ResultValueId",
                        column: x => x.ResultValueId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CO2Emissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CalculatedEmissionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CalculationForTransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MethodVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO2Emissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CO2Emissions_Value_CalculatedEmissionsId",
                        column: x => x.CalculatedEmissionsId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Composing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoadingUnitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompositionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitCompositionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    LocationOfPerformanceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Composing_UnitComposition_UnitCompositionId",
                        column: x => x.UnitCompositionId,
                        principalTable: "UnitComposition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContactDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactDetailType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoringId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitCompositionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetail_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactDetail_Check_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Check",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactDetail_Composing_ComposingId",
                        column: x => x.ComposingId,
                        principalTable: "Composing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactDetail_LoadingActivity_LoadingActivityId",
                        column: x => x.LoadingActivityId,
                        principalTable: "LoadingActivity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactDetail_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactDetail_UnitComposition_UnitCompositionId",
                        column: x => x.UnitCompositionId,
                        principalTable: "UnitComposition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomsInformation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IssuedForPieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherCustomsInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DgDeclaration",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IssuedForPieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AircraftLimitationInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplianceDeclarationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExclusiveUseIndicator = table.Column<bool>(type: "bit", nullable: false),
                    HandlingInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperDeclarationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgDeclaration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LengthId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VolumeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WidthId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_Value_HeightId",
                        column: x => x.HeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dimensions_Value_LengthId",
                        column: x => x.LengthId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dimensions_Value_VolumeId",
                        column: x => x.VolumeId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dimensions_Value_WidthId",
                        column: x => x.WidthId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EpermitConsignment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExaminingQuantityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsedToDateQuotaQuantity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpermitConsignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpermitConsignment_Value_ExaminingQuantityId",
                        column: x => x.ExaminingQuantityId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EpermitSignature",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ForEpermitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SignatoryCompanyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SecurityStampId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignatoryRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignatureStatement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignatureTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpermitSignature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExternalReference",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationOfCreationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OriginatorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Checksum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnswerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingRequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckTemplateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckTotalResultId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Co2EmissionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CustomsInformationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgProductRadioactiveId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgRadioactiveIsotopeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EpermitConsignmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EpermitSignatureId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExternalReferenceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsuranceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IotDeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LiveAnimalsEpermitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingUnitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PackagingTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PriceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PublicAuthorityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatingsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoutingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SecurityDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoringId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportLegsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMeansId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitCompositionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WaybillId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalReference_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_BookingOptionRequest_BookingOptionRequestId",
                        column: x => x.BookingOptionRequestId,
                        principalTable: "BookingOptionRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_BookingRequest_BookingRequestId",
                        column: x => x.BookingRequestId,
                        principalTable: "BookingRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_BookingShipment_BookingShipmentId",
                        column: x => x.BookingShipmentId,
                        principalTable: "BookingShipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_CO2Emissions_Co2EmissionsId",
                        column: x => x.Co2EmissionsId,
                        principalTable: "CO2Emissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_CheckTemplate_CheckTemplateId",
                        column: x => x.CheckTemplateId,
                        principalTable: "CheckTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_CheckTotalResult_CheckTotalResultId",
                        column: x => x.CheckTotalResultId,
                        principalTable: "CheckTotalResult",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Composing_ComposingId",
                        column: x => x.ComposingId,
                        principalTable: "Composing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_CustomsInformation_CustomsInformationId",
                        column: x => x.CustomsInformationId,
                        principalTable: "CustomsInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_DgDeclaration_DgDeclarationId",
                        column: x => x.DgDeclarationId,
                        principalTable: "DgDeclaration",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_DgProductRadioactive_DgProductRadioactiveId",
                        column: x => x.DgProductRadioactiveId,
                        principalTable: "DgProductRadioactive",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_DgRadioactiveIsotope_DgRadioactiveIsotopeId",
                        column: x => x.DgRadioactiveIsotopeId,
                        principalTable: "DgRadioactiveIsotope",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_EpermitConsignment_EpermitConsignmentId",
                        column: x => x.EpermitConsignmentId,
                        principalTable: "EpermitConsignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_EpermitSignature_EpermitSignatureId",
                        column: x => x.EpermitSignatureId,
                        principalTable: "EpermitSignature",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_ExternalReference_ExternalReferenceId",
                        column: x => x.ExternalReferenceId,
                        principalTable: "ExternalReference",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_LoadingActivity_LoadingActivityId",
                        column: x => x.LoadingActivityId,
                        principalTable: "LoadingActivity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_PackagingType_PackagingTypeId",
                        column: x => x.PackagingTypeId,
                        principalTable: "PackagingType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Ratings_RatingsId",
                        column: x => x.RatingsId,
                        principalTable: "Ratings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Routing_RoutingId",
                        column: x => x.RoutingId,
                        principalTable: "Routing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExternalReference_UnitComposition_UnitCompositionId",
                        column: x => x.UnitCompositionId,
                        principalTable: "UnitComposition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoveringOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsuredAmountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NvdIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_Value_InsuredAmountId",
                        column: x => x.InsuredAmountId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IotDevice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AssociatedObject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IotDeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingUnitId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMeansId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IotDevice_IotDevice_IotDeviceId",
                        column: x => x.IotDeviceId,
                        principalTable: "IotDevice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContainedItemInPieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DescribedByProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DimensionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemQuantityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductionCountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TargetCountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitPriceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LotNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantityForUnitPrice = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    EmergencyContactId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NetWeightMeasureId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReportableQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplementaryInfoPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplementaryInfoSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Country_ProductionCountryId",
                        column: x => x.ProductionCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Country_TargetCountryId",
                        column: x => x.TargetCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Value_ItemQuantityId",
                        column: x => x.ItemQuantityId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Value_NetWeightMeasureId",
                        column: x => x.NetWeightMeasureId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Value_UnitPriceId",
                        column: x => x.UnitPriceId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Value_WeightId",
                        column: x => x.WeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LiveAnimalsEpermit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConsigneeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CopyIndicator = table.Column<bool>(type: "bit", nullable: false),
                    EpermitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErmitTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitTypeOtherDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionPurposeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportContractId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportContractTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveAnimalsEpermit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loading",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OnTransportMeansId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingPositionIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    LocationOfPerformanceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loading_LoadingActivity_LoadingActivityId",
                        column: x => x.LoadingActivityId,
                        principalTable: "LoadingActivity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoadingMaterial",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadingMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadingMaterial_Composing_ComposingId",
                        column: x => x.ComposingId,
                        principalTable: "Composing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LoadingMaterial_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoadingUnit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TareWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UldSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadingUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadingUnit_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LoadingUnit_Value_TareWeightId",
                        column: x => x.TareWeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GeolocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoutingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Location_Geolocation_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Location_Routing_RoutingId",
                        column: x => x.RoutingId,
                        principalTable: "Routing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Moving",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    LocationOfPerformanceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moving", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moving_Location_LocationOfPerformanceId",
                        column: x => x.LocationOfPerformanceId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ScheduledLegs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartureLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegSequenceNumber = table.Column<int>(type: "int", nullable: false),
                    TransportIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledLegs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledLegs_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduledLegs_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduledLegs_Routing_RoutingId",
                        column: x => x.RoutingId,
                        principalTable: "Routing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeliveryLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalGrossWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalVolumetricWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargesIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSlac = table.Column<int>(type: "int", nullable: false),
                    WeightValuationIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_Location_DeliveryLocationId",
                        column: x => x.DeliveryLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shipment_Value_TotalGrossWeightId",
                        column: x => x.TotalGrossWeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shipment_VolumetricWeight_TotalVolumetricWeightId",
                        column: x => x.TotalVolumetricWeightId,
                        principalTable: "VolumetricWeight",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Storing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StoragePlaceIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoringType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    LocationOfPerformanceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActionEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storing_Location_LocationOfPerformanceId",
                        column: x => x.LocationOfPerformanceId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Storing_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransportLegs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartureLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegNumber = table.Column<int>(type: "int", nullable: false),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportLegs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportLegs_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportLegs_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportLegs_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Waybill",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarrierDeclarationPlaceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartureLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MasterWaybillId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AccountingInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierDeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarrierDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsignorDeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomsOriginCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCharges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCurrencyRate = table.Column<double>(type: "float", nullable: false),
                    ModularCheckNumber = table.Column<bool>(type: "bit", nullable: false),
                    OriginCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaybillType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReferredBookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waybill_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Booking_ReferredBookingOptionId",
                        column: x => x.ReferredBookingOptionId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Location_CarrierDeclarationPlaceId",
                        column: x => x.CarrierDeclarationPlaceId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Waybill_Waybill_MasterWaybillId",
                        column: x => x.MasterWaybillId,
                        principalTable: "Waybill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LogisticsAgent",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    AssociatedOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContactRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MovingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoringId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UnitCompositionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ParentOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessDelegationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AgentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentLocationIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsAgent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_AccessDelegation_AccessDelegationId",
                        column: x => x.AccessDelegationId,
                        principalTable: "AccessDelegation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Check_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Check",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Composing_ComposingId",
                        column: x => x.ComposingId,
                        principalTable: "Composing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_LoadingActivity_LoadingActivityId",
                        column: x => x.LoadingActivityId,
                        principalTable: "LoadingActivity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_LogisticsAgent_AssociatedOrganizationId",
                        column: x => x.AssociatedOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_LogisticsAgent_ParentOrganizationId",
                        column: x => x.ParentOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Moving_MovingId",
                        column: x => x.MovingId,
                        principalTable: "Moving",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_Storing_StoringId",
                        column: x => x.StoringId,
                        principalTable: "Storing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogisticsAgent_UnitComposition_UnitCompositionId",
                        column: x => x.UnitCompositionId,
                        principalTable: "UnitComposition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Piece",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContainedPieceInPieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContentProductionCountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DimensionsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GrossWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PackagingTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PartOfShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UldReferenceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VolumetricWeightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Coload = table.Column<bool>(type: "bit", nullable: false),
                    DeclaredValueForCarriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredValueForCustoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FulfillsUldTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NvdForCarriage = table.Column<bool>(type: "bit", nullable: false),
                    NvdForCustoms = table.Column<bool>(type: "bit", nullable: false),
                    PackageMarkCoded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagedeIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingMarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slac = table.Column<int>(type: "int", nullable: false),
                    Stackable = table.Column<bool>(type: "bit", nullable: false),
                    Turnable = table.Column<bool>(type: "bit", nullable: false),
                    Upid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComposingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    LoadingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DgDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AllPackedInOneIndicator = table.Column<bool>(type: "bit", nullable: true),
                    OverpackCriticalitySafetyIndexNumeric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverpackIndicator = table.Column<bool>(type: "bit", nullable: true),
                    OverpackT1 = table.Column<bool>(type: "bit", nullable: true),
                    OverpackTypeCode = table.Column<bool>(type: "bit", nullable: true),
                    QValueNumeric = table.Column<double>(type: "float", nullable: true),
                    ExportTradeCountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OriginTradeCountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AcquisitionDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnnualQuotaQuantity = table.Column<int>(type: "int", nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsTypeExtensionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginReferencePermitDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OriginReferencePermitId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginReferencePermitTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityAnimals = table.Column<int>(type: "int", nullable: true),
                    SpeciesCommonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeciesScientificName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecimenDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecimenTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpermitConsignmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piece_Composing_ComposingId",
                        column: x => x.ComposingId,
                        principalTable: "Composing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Country_ContentProductionCountryId",
                        column: x => x.ContentProductionCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Country_ExportTradeCountryId",
                        column: x => x.ExportTradeCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Country_OriginTradeCountryId",
                        column: x => x.OriginTradeCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_DgDeclaration_DgDeclarationId",
                        column: x => x.DgDeclarationId,
                        principalTable: "DgDeclaration",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_EpermitConsignment_EpermitConsignmentId",
                        column: x => x.EpermitConsignmentId,
                        principalTable: "EpermitConsignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_LoadingUnit_UldReferenceId",
                        column: x => x.UldReferenceId,
                        principalTable: "LoadingUnit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Loading_LoadingId",
                        column: x => x.LoadingId,
                        principalTable: "Loading",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_LogisticsAgent_TransportOrganizationId",
                        column: x => x.TransportOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_PackagingType_PackagingTypeId",
                        column: x => x.PackagingTypeId,
                        principalTable: "PackagingType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Piece_ContainedPieceInPieceId",
                        column: x => x.ContainedPieceInPieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Shipment_PartOfShipmentId",
                        column: x => x.PartOfShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_Value_GrossWeightId",
                        column: x => x.GrossWeightId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Piece_VolumetricWeight_VolumetricWeightId",
                        column: x => x.VolumetricWeightId,
                        principalTable: "VolumetricWeight",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CommodityItemNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCommodityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCommodityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    AdditionalHazardClassificationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizationInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplosiveCompatibilityGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardClassificationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagingDangerLevelCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackingInstructionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProperShippingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialProvisionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DgProductRadioactiveId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_DgProductRadioactive_DgProductRadioactiveId",
                        column: x => x.DgProductRadioactiveId,
                        principalTable: "DgProductRadioactive",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_LogisticsAgent_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SensorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IotDeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sensor_IotDevice_IotDeviceId",
                        column: x => x.IotDeviceId,
                        principalTable: "IotDevice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sensor_LogisticsAgent_TransportOrganizationId",
                        column: x => x.TransportOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasSubscriberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HasTopicTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasTopic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifyRequestStatusChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendLogisticsObjectBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludeSubscriptionEventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscription_LogisticsAgent_HasSubscriberId",
                        column: x => x.HasSubscriberId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscription_TopicType_HasTopicTypeId",
                        column: x => x.HasTopicTypeId,
                        principalTable: "TopicType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransportMeans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TransportOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TypicalCo2CoefficientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TypicalFuelConsumptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMeans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportMeans_LogisticsAgent_TransportOrganizationId",
                        column: x => x.TransportOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMeans_Value_TypicalCo2CoefficientId",
                        column: x => x.TypicalCo2CoefficientId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMeans_Value_TypicalFuelConsumptionId",
                        column: x => x.TypicalFuelConsumptionId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Party",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PartyDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingOptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckTemplateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WaybillId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Party_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_BookingOption_BookingOptionId",
                        column: x => x.BookingOptionId,
                        principalTable: "BookingOption",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_CheckTemplate_CheckTemplateId",
                        column: x => x.CheckTemplateId,
                        principalTable: "CheckTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_LogisticsAgent_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_LogisticsAgent_PartyDetailsId",
                        column: x => x.PartyDetailsId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Party_Waybill_WaybillId",
                        column: x => x.WaybillId,
                        principalTable: "Waybill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PieceProduct",
                columns: table => new
                {
                    ContentDescribedByProductsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescriptionForContentOfPiecesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceProduct", x => new { x.ContentDescribedByProductsId, x.DescriptionForContentOfPiecesId });
                    table.ForeignKey(
                        name: "FK_PieceProduct_Piece_DescriptionForContentOfPiecesId",
                        column: x => x.DescriptionForContentOfPiecesId,
                        principalTable: "Piece",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PieceProduct_Product_ContentDescribedByProductsId",
                        column: x => x.ContentDescribedByProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MeasurementValueId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RecordedGeolocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MeasurementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurement_Geolocation_RecordedGeolocationId",
                        column: x => x.RecordedGeolocationId,
                        principalTable: "Geolocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Measurement_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Measurement_Value_MeasurementValueId",
                        column: x => x.MeasurementValueId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransportMovement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartureLocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DistanceCalculatedId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DistanceMeasuredId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FuelAmountCalculatedId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FuelAmountMeasuredId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OperatingTransportMeansId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeQualifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMovement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportMovement_Location_ArrivalLocationId",
                        column: x => x.ArrivalLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_Location_DepartureLocationId",
                        column: x => x.DepartureLocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_TransportMeans_OperatingTransportMeansId",
                        column: x => x.OperatingTransportMeansId,
                        principalTable: "TransportMeans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_Value_DistanceCalculatedId",
                        column: x => x.DistanceCalculatedId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_Value_DistanceMeasuredId",
                        column: x => x.DistanceMeasuredId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_Value_FuelAmountCalculatedId",
                        column: x => x.FuelAmountCalculatedId,
                        principalTable: "Value",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransportMovement_Value_FuelAmountMeasuredId",
                        column: x => x.FuelAmountMeasuredId,
                        principalTable: "Value",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OtherIdentifier",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OtherIdentifierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LoadingMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PartyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIdentifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_LoadingMaterial_LoadingMaterialId",
                        column: x => x.LoadingMaterialId,
                        principalTable: "LoadingMaterial",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_LogisticsAgent_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherIdentifier_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovementTimes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementMilestone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementTimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportMovementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "RegulatedEntity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegulatedEntityIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwningOrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RegulatedEntityCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegulatedEntityExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityDeclarationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegulatedEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegulatedEntity_LogisticsAgent_OwningOrganizationId",
                        column: x => x.OwningOrganizationId,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SecurityDeclaration",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IssuedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceivedFromId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RegulatedEntityIssuerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdditionalSecurityInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroundsForExemption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OtherScreeningMethods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreeningMethods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkeletonIndicator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityDeclaration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityDeclaration_LogisticsAgent_IssuedById",
                        column: x => x.IssuedById,
                        principalTable: "LogisticsAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecurityDeclaration_Piece_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Piece",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecurityDeclaration_RegulatedEntity_ReceivedFromId",
                        column: x => x.ReceivedFromId,
                        principalTable: "RegulatedEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecurityDeclaration_RegulatedEntity_RegulatedEntityIssuerId",
                        column: x => x.RegulatedEntityIssuerId,
                        principalTable: "RegulatedEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessPermissions_HasLogisticsAgentId",
                table: "AccessPermissions",
                column: "HasLogisticsAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySequence_BookingId",
                table: "ActivitySequence",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryId",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Adjustments_BillingDetailsId",
                table: "Adjustments",
                column: "BillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AnswerActorId",
                table: "Answer",
                column: "AnswerActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AnswerValueId",
                table: "Answer",
                column: "AnswerValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_GivenAtLocationId",
                table: "Answer",
                column: "GivenAtLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDetails_TaxDueAgentId",
                table: "BillingDetails",
                column: "TaxDueAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDetails_TaxDueAirlineId",
                table: "BillingDetails",
                column: "TaxDueAirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookingRequestId",
                table: "Booking",
                column: "BookingRequestId",
                unique: true,
                filter: "[BookingRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOption_BookingRequestId",
                table: "BookingOption",
                column: "BookingRequestId",
                unique: true,
                filter: "[BookingRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOption_CarrierProductInfoId",
                table: "BookingOption",
                column: "CarrierProductInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOption_FromCarrierId",
                table: "BookingOption",
                column: "FromCarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOption_RequestRefId",
                table: "BookingOption",
                column: "RequestRefId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOption_TransportMovementId",
                table: "BookingOption",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOptionRequest_BookingShipmentDetailsId",
                table: "BookingOptionRequest",
                column: "BookingShipmentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOptionRequest_RatingsPreferenceId",
                table: "BookingOptionRequest",
                column: "RatingsPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOptionRequest_ShipmentDetailsId",
                table: "BookingOptionRequest",
                column: "ShipmentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOptionRequest_TransportMovementId",
                table: "BookingOptionRequest",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOptionRequest_UnitsPreferenceId",
                table: "BookingOptionRequest",
                column: "UnitsPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingShipment_TotalDimensionsId",
                table: "BookingShipment",
                column: "TotalDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingShipment_TotalGrossWeightId",
                table: "BookingShipment",
                column: "TotalGrossWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingShipment_TotalVolumetricWeightId",
                table: "BookingShipment",
                column: "TotalVolumetricWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTimes_BookingOptionId",
                table: "BookingTimes",
                column: "BookingOptionId",
                unique: true,
                filter: "[BookingOptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTimes_BookingOptionRequestId",
                table: "BookingTimes",
                column: "BookingOptionRequestId",
                unique: true,
                filter: "[BookingOptionRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristic_OfProductId",
                table: "Characteristic",
                column: "OfProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_AnswerId",
                table: "Check",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BillingDetailsId",
                table: "Check",
                column: "BillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BookingId",
                table: "Check",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BookingOptionId",
                table: "Check",
                column: "BookingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BookingOptionRequestId",
                table: "Check",
                column: "BookingOptionRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BookingRequestId",
                table: "Check",
                column: "BookingRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BookingShipmentId",
                table: "Check",
                column: "BookingShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_CheckerId",
                table: "Check",
                column: "CheckerId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_CheckId",
                table: "Check",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_CheckTotalResultId",
                table: "Check",
                column: "CheckTotalResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_Co2EmissionsId",
                table: "Check",
                column: "Co2EmissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ComposingId",
                table: "Check",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_CustomsInformationId",
                table: "Check",
                column: "CustomsInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_DgDeclarationId",
                table: "Check",
                column: "DgDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_DgProductRadioactiveId",
                table: "Check",
                column: "DgProductRadioactiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_DgRadioactiveIsotopeId",
                table: "Check",
                column: "DgRadioactiveIsotopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_EpermitConsignmentId",
                table: "Check",
                column: "EpermitConsignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_EpermitSignatureId",
                table: "Check",
                column: "EpermitSignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_InsuranceId",
                table: "Check",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_IotDeviceId",
                table: "Check",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ItemId",
                table: "Check",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LiveAnimalsEpermitId",
                table: "Check",
                column: "LiveAnimalsEpermitId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LoadingActivityId",
                table: "Check",
                column: "LoadingActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LoadingId",
                table: "Check",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LoadingMaterialId",
                table: "Check",
                column: "LoadingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LoadingUnitId",
                table: "Check",
                column: "LoadingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_LocationOfPerformanceId",
                table: "Check",
                column: "LocationOfPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_MovingId",
                table: "Check",
                column: "MovingId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_OrganizationId",
                table: "Check",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_PackagingTypeId",
                table: "Check",
                column: "PackagingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_PieceId",
                table: "Check",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_PriceId",
                table: "Check",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ProductId",
                table: "Check",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_QuestionId",
                table: "Check",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_RatingsId",
                table: "Check",
                column: "RatingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_RoutingId",
                table: "Check",
                column: "RoutingId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_SecurityDeclarationId",
                table: "Check",
                column: "SecurityDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_SensorId",
                table: "Check",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ShipmentId",
                table: "Check",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_StorageId",
                table: "Check",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_StoringId",
                table: "Check",
                column: "StoringId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_TransportLegsId",
                table: "Check",
                column: "TransportLegsId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_TransportMeansId",
                table: "Check",
                column: "TransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_TransportMovementId",
                table: "Check",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_UnitCompositionId",
                table: "Check",
                column: "UnitCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_UsedTemplateId",
                table: "Check",
                column: "UsedTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_WaybillId",
                table: "Check",
                column: "WaybillId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckExternalReference_ExternalReferencesId",
                table: "CheckExternalReference",
                column: "ExternalReferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckTemplate_LegacyTemplateId",
                table: "CheckTemplate",
                column: "LegacyTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckTotalResult_CertifiedByActorId",
                table: "CheckTotalResult",
                column: "CertifiedByActorId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckTotalResult_ResultValueId",
                table: "CheckTotalResult",
                column: "ResultValueId");

            migrationBuilder.CreateIndex(
                name: "IX_CO2Emissions_CalculatedEmissionsId",
                table: "CO2Emissions",
                column: "CalculatedEmissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CO2Emissions_CalculationForTransportMovementId",
                table: "CO2Emissions",
                column: "CalculationForTransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Composing_LoadingUnitId",
                table: "Composing",
                column: "LoadingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Composing_LocationOfPerformanceId",
                table: "Composing",
                column: "LocationOfPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Composing_UnitCompositionId",
                table: "Composing",
                column: "UnitCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_BookingId",
                table: "ContactDetail",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_CheckId",
                table: "ContactDetail",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_ComposingId",
                table: "ContactDetail",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_LoadingActivityId",
                table: "ContactDetail",
                column: "LoadingActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_LoadingId",
                table: "ContactDetail",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_MovingId",
                table: "ContactDetail",
                column: "MovingId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_PersonId",
                table: "ContactDetail",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_StorageId",
                table: "ContactDetail",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_StoringId",
                table: "ContactDetail",
                column: "StoringId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_TransportMovementId",
                table: "ContactDetail",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetail_UnitCompositionId",
                table: "ContactDetail",
                column: "UnitCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsInformation_IssuedForPieceId",
                table: "CustomsInformation",
                column: "IssuedForPieceId");

            migrationBuilder.CreateIndex(
                name: "IX_DgDeclaration_IssuedForPieceId",
                table: "DgDeclaration",
                column: "IssuedForPieceId");

            migrationBuilder.CreateIndex(
                name: "IX_DgRadioactiveIsotope_ContentOfDgProductRadioactiveId",
                table: "DgRadioactiveIsotope",
                column: "ContentOfDgProductRadioactiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_HeightId",
                table: "Dimensions",
                column: "HeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_LengthId",
                table: "Dimensions",
                column: "LengthId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_VolumeId",
                table: "Dimensions",
                column: "VolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_WidthId",
                table: "Dimensions",
                column: "WidthId");

            migrationBuilder.CreateIndex(
                name: "IX_EpermitConsignment_ExaminingQuantityId",
                table: "EpermitConsignment",
                column: "ExaminingQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_EpermitConsignment_PermitId",
                table: "EpermitConsignment",
                column: "PermitId");

            migrationBuilder.CreateIndex(
                name: "IX_EpermitSignature_ForEpermitId",
                table: "EpermitSignature",
                column: "ForEpermitId");

            migrationBuilder.CreateIndex(
                name: "IX_EpermitSignature_SignatoryCompanyId",
                table: "EpermitSignature",
                column: "SignatoryCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorDetail_ErrorId",
                table: "ErrorDetail",
                column: "ErrorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ActorId",
                table: "ExternalReference",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_AnswerId",
                table: "ExternalReference",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BillingDetailsId",
                table: "ExternalReference",
                column: "BillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BookingId",
                table: "ExternalReference",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BookingOptionId",
                table: "ExternalReference",
                column: "BookingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BookingOptionRequestId",
                table: "ExternalReference",
                column: "BookingOptionRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BookingRequestId",
                table: "ExternalReference",
                column: "BookingRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_BookingShipmentId",
                table: "ExternalReference",
                column: "BookingShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_CheckTemplateId",
                table: "ExternalReference",
                column: "CheckTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_CheckTotalResultId",
                table: "ExternalReference",
                column: "CheckTotalResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_Co2EmissionsId",
                table: "ExternalReference",
                column: "Co2EmissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ComposingId",
                table: "ExternalReference",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_CustomsInformationId",
                table: "ExternalReference",
                column: "CustomsInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_DgDeclarationId",
                table: "ExternalReference",
                column: "DgDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_DgProductRadioactiveId",
                table: "ExternalReference",
                column: "DgProductRadioactiveId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_DgRadioactiveIsotopeId",
                table: "ExternalReference",
                column: "DgRadioactiveIsotopeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_EpermitConsignmentId",
                table: "ExternalReference",
                column: "EpermitConsignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_EpermitSignatureId",
                table: "ExternalReference",
                column: "EpermitSignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ExternalReferenceId",
                table: "ExternalReference",
                column: "ExternalReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_InsuranceId",
                table: "ExternalReference",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_IotDeviceId",
                table: "ExternalReference",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ItemId",
                table: "ExternalReference",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LiveAnimalsEpermitId",
                table: "ExternalReference",
                column: "LiveAnimalsEpermitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LoadingActivityId",
                table: "ExternalReference",
                column: "LoadingActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LoadingId",
                table: "ExternalReference",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LoadingMaterialId",
                table: "ExternalReference",
                column: "LoadingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LoadingUnitId",
                table: "ExternalReference",
                column: "LoadingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_LocationOfCreationId",
                table: "ExternalReference",
                column: "LocationOfCreationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_MovingId",
                table: "ExternalReference",
                column: "MovingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_OriginatorId",
                table: "ExternalReference",
                column: "OriginatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_PackagingTypeId",
                table: "ExternalReference",
                column: "PackagingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_PersonId",
                table: "ExternalReference",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_PieceId",
                table: "ExternalReference",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_PriceId",
                table: "ExternalReference",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ProductId",
                table: "ExternalReference",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_PublicAuthorityId",
                table: "ExternalReference",
                column: "PublicAuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_QuestionId",
                table: "ExternalReference",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_RatingsId",
                table: "ExternalReference",
                column: "RatingsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_RoutingId",
                table: "ExternalReference",
                column: "RoutingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_SecurityDeclarationId",
                table: "ExternalReference",
                column: "SecurityDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_SensorId",
                table: "ExternalReference",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_ShipmentId",
                table: "ExternalReference",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_StorageId",
                table: "ExternalReference",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_StoringId",
                table: "ExternalReference",
                column: "StoringId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_TransportLegsId",
                table: "ExternalReference",
                column: "TransportLegsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_TransportMeansId",
                table: "ExternalReference",
                column: "TransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_TransportMovementId",
                table: "ExternalReference",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_UnitCompositionId",
                table: "ExternalReference",
                column: "UnitCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReference_WaybillId",
                table: "ExternalReference",
                column: "WaybillId");

            migrationBuilder.CreateIndex(
                name: "IX_Geolocation_ElevationId",
                table: "Geolocation",
                column: "ElevationId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CoveringOrganizationId",
                table: "Insurance",
                column: "CoveringOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_InsuredAmountId",
                table: "Insurance",
                column: "InsuredAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_ShipmentId",
                table: "Insurance",
                column: "ShipmentId",
                unique: true,
                filter: "[ShipmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_IotDeviceId",
                table: "IotDevice",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_ItemId",
                table: "IotDevice",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_LoadingMaterialId",
                table: "IotDevice",
                column: "LoadingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_LoadingUnitId",
                table: "IotDevice",
                column: "LoadingUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_LocationId",
                table: "IotDevice",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_ManufacturerId",
                table: "IotDevice",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_PieceId",
                table: "IotDevice",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_SensorId",
                table: "IotDevice",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_ShipmentId",
                table: "IotDevice",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_TransportMeansId",
                table: "IotDevice",
                column: "TransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevice_TransportOrganizationId",
                table: "IotDevice",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ContainedItemInPieceId",
                table: "Item",
                column: "ContainedItemInPieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DescribedByProductId",
                table: "Item",
                column: "DescribedByProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DimensionsId",
                table: "Item",
                column: "DimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_EmergencyContactId",
                table: "Item",
                column: "EmergencyContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemQuantityId",
                table: "Item",
                column: "ItemQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_NetWeightMeasureId",
                table: "Item",
                column: "NetWeightMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ProductionCountryId",
                table: "Item",
                column: "ProductionCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TargetCountryId",
                table: "Item",
                column: "TargetCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TransportOrganizationId",
                table: "Item",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UnitPriceId",
                table: "Item",
                column: "UnitPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_WeightId",
                table: "Item",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_LiveAnimalsEpermit_ConsigneeId",
                table: "LiveAnimalsEpermit",
                column: "ConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_LoadingActivityId",
                table: "Loading",
                column: "LoadingActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_LocationOfPerformanceId",
                table: "Loading",
                column: "LocationOfPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Loading_OnTransportMeansId",
                table: "Loading",
                column: "OnTransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingMaterial_ComposingId",
                table: "LoadingMaterial",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingMaterial_LoadingId",
                table: "LoadingMaterial",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingMaterial_ManufacturerId",
                table: "LoadingMaterial",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingMaterial_TransportOrganizationId",
                table: "LoadingMaterial",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingUnit_LoadingId",
                table: "LoadingUnit",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingUnit_TareWeightId",
                table: "LoadingUnit",
                column: "TareWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadingUnit_TransportOrganizationId",
                table: "LoadingUnit",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_AddressId",
                table: "Location",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_GeolocationId",
                table: "Location",
                column: "GeolocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_OrganizationId",
                table: "Location",
                column: "OrganizationId",
                unique: true,
                filter: "[OrganizationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_RoutingId",
                table: "Location",
                column: "RoutingId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_AccessDelegationId",
                table: "LogisticsAgent",
                column: "AccessDelegationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_AssociatedOrganizationId",
                table: "LogisticsAgent",
                column: "AssociatedOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_BookingId",
                table: "LogisticsAgent",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_CheckId",
                table: "LogisticsAgent",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_ComposingId",
                table: "LogisticsAgent",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_LoadingActivityId",
                table: "LogisticsAgent",
                column: "LoadingActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_LoadingId",
                table: "LogisticsAgent",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_MovingId",
                table: "LogisticsAgent",
                column: "MovingId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_ParentOrganizationId",
                table: "LogisticsAgent",
                column: "ParentOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_StorageId",
                table: "LogisticsAgent",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_StoringId",
                table: "LogisticsAgent",
                column: "StoringId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_TransportMovementId",
                table: "LogisticsAgent",
                column: "TransportMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticsAgent_UnitCompositionId",
                table: "LogisticsAgent",
                column: "UnitCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurement_MeasurementValueId",
                table: "Measurement",
                column: "MeasurementValueId");

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
                name: "IX_Moving_LocationOfPerformanceId",
                table: "Moving",
                column: "LocationOfPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_PatchOperationId",
                table: "Operation",
                column: "PatchOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationObject_OperationId",
                table: "OperationObject",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_ItemId",
                table: "OtherIdentifier",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_LoadingMaterialId",
                table: "OtherIdentifier",
                column: "LoadingMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_OrganizationId",
                table: "OtherIdentifier",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_PartyId",
                table: "OtherIdentifier",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_PieceId",
                table: "OtherIdentifier",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherIdentifier_ProductId",
                table: "OtherIdentifier",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_AnswerId",
                table: "Party",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_BookingOptionId",
                table: "Party",
                column: "BookingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_CheckTemplateId",
                table: "Party",
                column: "CheckTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_OrganizationId",
                table: "Party",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_PartyDetailsId",
                table: "Party",
                column: "PartyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_PieceId",
                table: "Party",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_ShipmentId",
                table: "Party",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_WaybillId",
                table: "Party",
                column: "WaybillId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_AccessDelegationId",
                table: "Permission",
                column: "AccessDelegationId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_AccessPermissionsId",
                table: "Permission",
                column: "AccessPermissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_ComposingId",
                table: "Piece",
                column: "ComposingId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_ContainedPieceInPieceId",
                table: "Piece",
                column: "ContainedPieceInPieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_ContentProductionCountryId",
                table: "Piece",
                column: "ContentProductionCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_DgDeclarationId",
                table: "Piece",
                column: "DgDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_DimensionsId",
                table: "Piece",
                column: "DimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_EpermitConsignmentId",
                table: "Piece",
                column: "EpermitConsignmentId",
                unique: true,
                filter: "[EpermitConsignmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_ExportTradeCountryId",
                table: "Piece",
                column: "ExportTradeCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_GrossWeightId",
                table: "Piece",
                column: "GrossWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_LoadingId",
                table: "Piece",
                column: "LoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_OriginTradeCountryId",
                table: "Piece",
                column: "OriginTradeCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_PackagingTypeId",
                table: "Piece",
                column: "PackagingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_PartOfShipmentId",
                table: "Piece",
                column: "PartOfShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_TransportOrganizationId",
                table: "Piece",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_UldReferenceId",
                table: "Piece",
                column: "UldReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_VolumetricWeightId",
                table: "Piece",
                column: "VolumetricWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_PieceProduct_DescriptionForContentOfPiecesId",
                table: "PieceProduct",
                column: "DescriptionForContentOfPiecesId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_BookingOptionId",
                table: "Price",
                column: "BookingOptionId",
                unique: true,
                filter: "[BookingOptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Price_ForBookingOptionRequestId",
                table: "Price",
                column: "ForBookingOptionRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceRatings_RatingsId",
                table: "PriceRatings",
                column: "RatingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DgProductRadioactiveId",
                table: "Product",
                column: "DgProductRadioactiveId",
                unique: true,
                filter: "[DgProductRadioactiveId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerId",
                table: "Question",
                column: "AnswerId",
                unique: true,
                filter: "[AnswerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CheckTemplateId",
                table: "Question",
                column: "CheckTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Ranges_RatingsId",
                table: "Ranges",
                column: "RatingsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegulatedEntity_OwningOrganizationId",
                table: "RegulatedEntity",
                column: "OwningOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RegulatedEntity_SecurityDeclarationId",
                table: "RegulatedEntity",
                column: "SecurityDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routing_BookingOptionId",
                table: "Routing",
                column: "BookingOptionId",
                unique: true,
                filter: "[BookingOptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Routing_BookingOptionRequestId",
                table: "Routing",
                column: "BookingOptionRequestId",
                unique: true,
                filter: "[BookingOptionRequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledLegs_ArrivalLocationId",
                table: "ScheduledLegs",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledLegs_DepartureLocationId",
                table: "ScheduledLegs",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledLegs_RoutingId",
                table: "ScheduledLegs",
                column: "RoutingId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDeclaration_IssuedById",
                table: "SecurityDeclaration",
                column: "IssuedById");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDeclaration_PieceId",
                table: "SecurityDeclaration",
                column: "PieceId",
                unique: true,
                filter: "[PieceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDeclaration_ReceivedFromId",
                table: "SecurityDeclaration",
                column: "ReceivedFromId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDeclaration_RegulatedEntityIssuerId",
                table: "SecurityDeclaration",
                column: "RegulatedEntityIssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_IotDeviceId",
                table: "Sensor",
                column: "IotDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_TransportOrganizationId",
                table: "Sensor",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_DeliveryLocationId",
                table: "Shipment",
                column: "DeliveryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_TotalGrossWeightId",
                table: "Shipment",
                column: "TotalGrossWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_TotalVolumetricWeightId",
                table: "Shipment",
                column: "TotalVolumetricWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Storing_LocationOfPerformanceId",
                table: "Storing",
                column: "LocationOfPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Storing_StorageId",
                table: "Storing",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_HasSubscriberId",
                table: "Subscription",
                column: "HasSubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_HasTopicTypeId",
                table: "Subscription",
                column: "HasTopicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportLegs_ArrivalLocationId",
                table: "TransportLegs",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportLegs_BookingOptionId",
                table: "TransportLegs",
                column: "BookingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportLegs_DepartureLocationId",
                table: "TransportLegs",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMeans_TransportOrganizationId",
                table: "TransportMeans",
                column: "TransportOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMeans_TypicalCo2CoefficientId",
                table: "TransportMeans",
                column: "TypicalCo2CoefficientId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMeans_TypicalFuelConsumptionId",
                table: "TransportMeans",
                column: "TypicalFuelConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_ArrivalLocationId",
                table: "TransportMovement",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_DepartureLocationId",
                table: "TransportMovement",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_DistanceCalculatedId",
                table: "TransportMovement",
                column: "DistanceCalculatedId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_DistanceMeasuredId",
                table: "TransportMovement",
                column: "DistanceMeasuredId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_FuelAmountCalculatedId",
                table: "TransportMovement",
                column: "FuelAmountCalculatedId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_FuelAmountMeasuredId",
                table: "TransportMovement",
                column: "FuelAmountMeasuredId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportMovement_OperatingTransportMeansId",
                table: "TransportMovement",
                column: "OperatingTransportMeansId");

            migrationBuilder.CreateIndex(
                name: "IX_VolumetricWeight_ChargeableWeightId",
                table: "VolumetricWeight",
                column: "ChargeableWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_VolumetricWeight_ConversionFactorId",
                table: "VolumetricWeight",
                column: "ConversionFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ArrivalLocationId",
                table: "Waybill",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_BillingDetailsId",
                table: "Waybill",
                column: "BillingDetailsId",
                unique: true,
                filter: "[BillingDetailsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_CarrierDeclarationPlaceId",
                table: "Waybill",
                column: "CarrierDeclarationPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_DepartureLocationId",
                table: "Waybill",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_MasterWaybillId",
                table: "Waybill",
                column: "MasterWaybillId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ReferredBookingOptionId",
                table: "Waybill",
                column: "ReferredBookingOptionId",
                unique: true,
                filter: "[ReferredBookingOptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_ShipmentId",
                table: "Waybill",
                column: "ShipmentId",
                unique: true,
                filter: "[ShipmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessPermissions_LogisticsAgent_HasLogisticsAgentId",
                table: "AccessPermissions",
                column: "HasLogisticsAgentId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Location_GivenAtLocationId",
                table: "Answer",
                column: "GivenAtLocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_LogisticsAgent_AnswerActorId",
                table: "Answer",
                column: "AnswerActorId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOption_BookingOptionRequest_RequestRefId",
                table: "BookingOption",
                column: "RequestRefId",
                principalTable: "BookingOptionRequest",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOption_LogisticsAgent_FromCarrierId",
                table: "BookingOption",
                column: "FromCarrierId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOption_TransportMovement_TransportMovementId",
                table: "BookingOption",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOptionRequest_BookingShipment_BookingShipmentDetailsId",
                table: "BookingOptionRequest",
                column: "BookingShipmentDetailsId",
                principalTable: "BookingShipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOptionRequest_Shipment_ShipmentDetailsId",
                table: "BookingOptionRequest",
                column: "ShipmentDetailsId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingOptionRequest_TransportMovement_TransportMovementId",
                table: "BookingOptionRequest",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingShipment_Dimensions_TotalDimensionsId",
                table: "BookingShipment",
                column: "TotalDimensionsId",
                principalTable: "Dimensions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristic_Product_OfProductId",
                table: "Characteristic",
                column: "OfProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_CO2Emissions_Co2EmissionsId",
                table: "Check",
                column: "Co2EmissionsId",
                principalTable: "CO2Emissions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_CheckTemplate_UsedTemplateId",
                table: "Check",
                column: "UsedTemplateId",
                principalTable: "CheckTemplate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_CheckTotalResult_CheckTotalResultId",
                table: "Check",
                column: "CheckTotalResultId",
                principalTable: "CheckTotalResult",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Composing_ComposingId",
                table: "Check",
                column: "ComposingId",
                principalTable: "Composing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_CustomsInformation_CustomsInformationId",
                table: "Check",
                column: "CustomsInformationId",
                principalTable: "CustomsInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_DgDeclaration_DgDeclarationId",
                table: "Check",
                column: "DgDeclarationId",
                principalTable: "DgDeclaration",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_EpermitConsignment_EpermitConsignmentId",
                table: "Check",
                column: "EpermitConsignmentId",
                principalTable: "EpermitConsignment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_EpermitSignature_EpermitSignatureId",
                table: "Check",
                column: "EpermitSignatureId",
                principalTable: "EpermitSignature",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Insurance_InsuranceId",
                table: "Check",
                column: "InsuranceId",
                principalTable: "Insurance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_IotDevice_IotDeviceId",
                table: "Check",
                column: "IotDeviceId",
                principalTable: "IotDevice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Item_ItemId",
                table: "Check",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_LiveAnimalsEpermit_LiveAnimalsEpermitId",
                table: "Check",
                column: "LiveAnimalsEpermitId",
                principalTable: "LiveAnimalsEpermit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_LoadingMaterial_LoadingMaterialId",
                table: "Check",
                column: "LoadingMaterialId",
                principalTable: "LoadingMaterial",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_LoadingUnit_LoadingUnitId",
                table: "Check",
                column: "LoadingUnitId",
                principalTable: "LoadingUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Loading_LoadingId",
                table: "Check",
                column: "LoadingId",
                principalTable: "Loading",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Location_LocationOfPerformanceId",
                table: "Check",
                column: "LocationOfPerformanceId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_LogisticsAgent_CheckerId",
                table: "Check",
                column: "CheckerId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_LogisticsAgent_OrganizationId",
                table: "Check",
                column: "OrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Moving_MovingId",
                table: "Check",
                column: "MovingId",
                principalTable: "Moving",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Piece_PieceId",
                table: "Check",
                column: "PieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Product_ProductId",
                table: "Check",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Question_QuestionId",
                table: "Check",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_SecurityDeclaration_SecurityDeclarationId",
                table: "Check",
                column: "SecurityDeclarationId",
                principalTable: "SecurityDeclaration",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Sensor_SensorId",
                table: "Check",
                column: "SensorId",
                principalTable: "Sensor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Shipment_ShipmentId",
                table: "Check",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Storing_StoringId",
                table: "Check",
                column: "StoringId",
                principalTable: "Storing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_TransportLegs_TransportLegsId",
                table: "Check",
                column: "TransportLegsId",
                principalTable: "TransportLegs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_TransportMeans_TransportMeansId",
                table: "Check",
                column: "TransportMeansId",
                principalTable: "TransportMeans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_TransportMovement_TransportMovementId",
                table: "Check",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Waybill_WaybillId",
                table: "Check",
                column: "WaybillId",
                principalTable: "Waybill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckExternalReference_ExternalReference_ExternalReferencesId",
                table: "CheckExternalReference",
                column: "ExternalReferencesId",
                principalTable: "ExternalReference",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckTemplate_ExternalReference_LegacyTemplateId",
                table: "CheckTemplate",
                column: "LegacyTemplateId",
                principalTable: "ExternalReference",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckTotalResult_LogisticsAgent_CertifiedByActorId",
                table: "CheckTotalResult",
                column: "CertifiedByActorId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CO2Emissions_TransportMovement_CalculationForTransportMovementId",
                table: "CO2Emissions",
                column: "CalculationForTransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Composing_LoadingUnit_LoadingUnitId",
                table: "Composing",
                column: "LoadingUnitId",
                principalTable: "LoadingUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Composing_Location_LocationOfPerformanceId",
                table: "Composing",
                column: "LocationOfPerformanceId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetail_Loading_LoadingId",
                table: "ContactDetail",
                column: "LoadingId",
                principalTable: "Loading",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetail_LogisticsAgent_PersonId",
                table: "ContactDetail",
                column: "PersonId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetail_Moving_MovingId",
                table: "ContactDetail",
                column: "MovingId",
                principalTable: "Moving",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetail_Storing_StoringId",
                table: "ContactDetail",
                column: "StoringId",
                principalTable: "Storing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetail_TransportMovement_TransportMovementId",
                table: "ContactDetail",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomsInformation_Piece_IssuedForPieceId",
                table: "CustomsInformation",
                column: "IssuedForPieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DgDeclaration_Piece_IssuedForPieceId",
                table: "DgDeclaration",
                column: "IssuedForPieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_Shipment_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EpermitConsignment_LiveAnimalsEpermit_PermitId",
                table: "EpermitConsignment",
                column: "PermitId",
                principalTable: "LiveAnimalsEpermit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EpermitSignature_LiveAnimalsEpermit_ForEpermitId",
                table: "EpermitSignature",
                column: "ForEpermitId",
                principalTable: "LiveAnimalsEpermit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EpermitSignature_LogisticsAgent_SignatoryCompanyId",
                table: "EpermitSignature",
                column: "SignatoryCompanyId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Insurance_InsuranceId",
                table: "ExternalReference",
                column: "InsuranceId",
                principalTable: "Insurance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_IotDevice_IotDeviceId",
                table: "ExternalReference",
                column: "IotDeviceId",
                principalTable: "IotDevice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Item_ItemId",
                table: "ExternalReference",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LiveAnimalsEpermit_LiveAnimalsEpermitId",
                table: "ExternalReference",
                column: "LiveAnimalsEpermitId",
                principalTable: "LiveAnimalsEpermit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LoadingMaterial_LoadingMaterialId",
                table: "ExternalReference",
                column: "LoadingMaterialId",
                principalTable: "LoadingMaterial",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LoadingUnit_LoadingUnitId",
                table: "ExternalReference",
                column: "LoadingUnitId",
                principalTable: "LoadingUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Loading_LoadingId",
                table: "ExternalReference",
                column: "LoadingId",
                principalTable: "Loading",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Location_LocationOfCreationId",
                table: "ExternalReference",
                column: "LocationOfCreationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_ActorId",
                table: "ExternalReference",
                column: "ActorId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_OriginatorId",
                table: "ExternalReference",
                column: "OriginatorId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_PersonId",
                table: "ExternalReference",
                column: "PersonId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_PublicAuthorityId",
                table: "ExternalReference",
                column: "PublicAuthorityId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Moving_MovingId",
                table: "ExternalReference",
                column: "MovingId",
                principalTable: "Moving",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Piece_PieceId",
                table: "ExternalReference",
                column: "PieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Product_ProductId",
                table: "ExternalReference",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_SecurityDeclaration_SecurityDeclarationId",
                table: "ExternalReference",
                column: "SecurityDeclarationId",
                principalTable: "SecurityDeclaration",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Sensor_SensorId",
                table: "ExternalReference",
                column: "SensorId",
                principalTable: "Sensor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Shipment_ShipmentId",
                table: "ExternalReference",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Storing_StoringId",
                table: "ExternalReference",
                column: "StoringId",
                principalTable: "Storing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_TransportLegs_TransportLegsId",
                table: "ExternalReference",
                column: "TransportLegsId",
                principalTable: "TransportLegs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_TransportMeans_TransportMeansId",
                table: "ExternalReference",
                column: "TransportMeansId",
                principalTable: "TransportMeans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_TransportMovement_TransportMovementId",
                table: "ExternalReference",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalReference_Waybill_WaybillId",
                table: "ExternalReference",
                column: "WaybillId",
                principalTable: "Waybill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_LogisticsAgent_CoveringOrganizationId",
                table: "Insurance",
                column: "CoveringOrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Shipment_ShipmentId",
                table: "Insurance",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_Item_ItemId",
                table: "IotDevice",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_LoadingMaterial_LoadingMaterialId",
                table: "IotDevice",
                column: "LoadingMaterialId",
                principalTable: "LoadingMaterial",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_LoadingUnit_LoadingUnitId",
                table: "IotDevice",
                column: "LoadingUnitId",
                principalTable: "LoadingUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_Location_LocationId",
                table: "IotDevice",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_LogisticsAgent_ManufacturerId",
                table: "IotDevice",
                column: "ManufacturerId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_LogisticsAgent_TransportOrganizationId",
                table: "IotDevice",
                column: "TransportOrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_Piece_PieceId",
                table: "IotDevice",
                column: "PieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_Sensor_SensorId",
                table: "IotDevice",
                column: "SensorId",
                principalTable: "Sensor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_Shipment_ShipmentId",
                table: "IotDevice",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IotDevice_TransportMeans_TransportMeansId",
                table: "IotDevice",
                column: "TransportMeansId",
                principalTable: "TransportMeans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_LogisticsAgent_EmergencyContactId",
                table: "Item",
                column: "EmergencyContactId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_LogisticsAgent_TransportOrganizationId",
                table: "Item",
                column: "TransportOrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Piece_ContainedItemInPieceId",
                table: "Item",
                column: "ContainedItemInPieceId",
                principalTable: "Piece",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Product_DescribedByProductId",
                table: "Item",
                column: "DescribedByProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveAnimalsEpermit_LogisticsAgent_ConsigneeId",
                table: "LiveAnimalsEpermit",
                column: "ConsigneeId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loading_Location_LocationOfPerformanceId",
                table: "Loading",
                column: "LocationOfPerformanceId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loading_TransportMeans_OnTransportMeansId",
                table: "Loading",
                column: "OnTransportMeansId",
                principalTable: "TransportMeans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadingMaterial_LogisticsAgent_ManufacturerId",
                table: "LoadingMaterial",
                column: "ManufacturerId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadingMaterial_LogisticsAgent_TransportOrganizationId",
                table: "LoadingMaterial",
                column: "TransportOrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadingUnit_LogisticsAgent_TransportOrganizationId",
                table: "LoadingUnit",
                column: "TransportOrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_LogisticsAgent_OrganizationId",
                table: "Location",
                column: "OrganizationId",
                principalTable: "LogisticsAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LogisticsAgent_TransportMovement_TransportMovementId",
                table: "LogisticsAgent",
                column: "TransportMovementId",
                principalTable: "TransportMovement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegulatedEntity_SecurityDeclaration_SecurityDeclarationId",
                table: "RegulatedEntity",
                column: "SecurityDeclarationId",
                principalTable: "SecurityDeclaration",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_LogisticsAgent_AnswerActorId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOption_LogisticsAgent_FromCarrierId",
                table: "BookingOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_LogisticsAgent_CheckerId",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_LogisticsAgent_OrganizationId",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckTotalResult_LogisticsAgent_CertifiedByActorId",
                table: "CheckTotalResult");

            migrationBuilder.DropForeignKey(
                name: "FK_EpermitSignature_LogisticsAgent_SignatoryCompanyId",
                table: "EpermitSignature");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_ActorId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_OriginatorId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_PersonId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_LogisticsAgent_PublicAuthorityId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_LogisticsAgent_CoveringOrganizationId",
                table: "Insurance");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_LogisticsAgent_ManufacturerId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_LogisticsAgent_TransportOrganizationId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_LogisticsAgent_EmergencyContactId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_LogisticsAgent_TransportOrganizationId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_LiveAnimalsEpermit_LogisticsAgent_ConsigneeId",
                table: "LiveAnimalsEpermit");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadingMaterial_LogisticsAgent_ManufacturerId",
                table: "LoadingMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadingMaterial_LogisticsAgent_TransportOrganizationId",
                table: "LoadingMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadingUnit_LogisticsAgent_TransportOrganizationId",
                table: "LoadingUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_LogisticsAgent_OrganizationId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_LogisticsAgent_TransportOrganizationId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_LogisticsAgent_ManufacturerId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_RegulatedEntity_LogisticsAgent_OwningOrganizationId",
                table: "RegulatedEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDeclaration_LogisticsAgent_IssuedById",
                table: "SecurityDeclaration");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensor_LogisticsAgent_TransportOrganizationId",
                table: "Sensor");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMeans_LogisticsAgent_TransportOrganizationId",
                table: "TransportMeans");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Booking_BookingId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_Booking_ReferredBookingOptionId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Country_CountryId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Country_ProductionCountryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Country_TargetCountryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Country_ContentProductionCountryId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Country_ExportTradeCountryId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Country_OriginTradeCountryId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_BillingDetails_BillingDetailsId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_BillingDetails_BillingDetailsId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Location_GivenAtLocationId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Composing_Location_LocationOfPerformanceId",
                table: "Composing");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Location_LocationOfCreationId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_Location_LocationId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_Loading_Location_LocationOfPerformanceId",
                table: "Loading");

            migrationBuilder.DropForeignKey(
                name: "FK_Moving_Location_LocationOfPerformanceId",
                table: "Moving");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Location_DeliveryLocationId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Storing_Location_LocationOfPerformanceId",
                table: "Storing");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportLegs_Location_ArrivalLocationId",
                table: "TransportLegs");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportLegs_Location_DepartureLocationId",
                table: "TransportLegs");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Location_ArrivalLocationId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Location_DepartureLocationId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_Location_ArrivalLocationId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_Location_CarrierDeclarationPlaceId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_Location_DepartureLocationId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Value_AnswerValueId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOptionRequest_Value_UnitsPreferenceId",
                table: "BookingOptionRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingShipment_Value_TotalGrossWeightId",
                table: "BookingShipment");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckTotalResult_Value_ResultValueId",
                table: "CheckTotalResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CO2Emissions_Value_CalculatedEmissionsId",
                table: "CO2Emissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Value_HeightId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Value_LengthId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Value_VolumeId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Value_WidthId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpermitConsignment_Value_ExaminingQuantityId",
                table: "EpermitConsignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Value_InsuredAmountId",
                table: "Insurance");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Value_ItemQuantityId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Value_NetWeightMeasureId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Value_UnitPriceId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Value_WeightId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadingUnit_Value_TareWeightId",
                table: "LoadingUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Value_GrossWeightId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_Value_TotalGrossWeightId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMeans_Value_TypicalCo2CoefficientId",
                table: "TransportMeans");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMeans_Value_TypicalFuelConsumptionId",
                table: "TransportMeans");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Value_DistanceCalculatedId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Value_DistanceMeasuredId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Value_FuelAmountCalculatedId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportMovement_Value_FuelAmountMeasuredId",
                table: "TransportMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_VolumetricWeight_Value_ChargeableWeightId",
                table: "VolumetricWeight");

            migrationBuilder.DropForeignKey(
                name: "FK_VolumetricWeight_Value_ConversionFactorId",
                table: "VolumetricWeight");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOption_BookingRequest_BookingRequestId",
                table: "BookingOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_BookingRequest_BookingRequestId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOption_BookingOptionRequest_RequestRefId",
                table: "BookingOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_BookingOptionRequest_BookingOptionRequestId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_BookingOptionRequest_ForBookingOptionRequestId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Routing_BookingOptionRequest_BookingOptionRequestId",
                table: "Routing");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOption_CarrierProduct_CarrierProductInfoId",
                table: "BookingOption");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingOption_TransportMovement_TransportMovementId",
                table: "BookingOption");

            migrationBuilder.DropForeignKey(
                name: "FK_CO2Emissions_TransportMovement_CalculationForTransportMovementId",
                table: "CO2Emissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_TransportMovement_TransportMovementId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_BookingShipment_BookingShipmentId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Ratings_RatingsId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipment_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Shipment_ShipmentId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Shipment_ShipmentId",
                table: "Insurance");

            migrationBuilder.DropForeignKey(
                name: "FK_IotDevice_Shipment_ShipmentId",
                table: "IotDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Shipment_PartOfShipmentId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Waybill_Shipment_ShipmentId",
                table: "Waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Dimensions_DimensionsId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Dimensions_DimensionsId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_VolumetricWeight_VolumetricWeightId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_BookingOption_BookingOptionId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_BookingOption_BookingOptionId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Routing_BookingOption_BookingOptionId",
                table: "Routing");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportLegs_BookingOption_BookingOptionId",
                table: "TransportLegs");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Product_ProductId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Product_DescribedByProductId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_Answer_AnswerId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Answer_AnswerId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_CO2Emissions_Co2EmissionsId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalReference_CheckTemplate_CheckTemplateId",
                table: "ExternalReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_CheckTemplate_CheckTemplateId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadingMaterial_Composing_ComposingId",
                table: "LoadingMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Composing_ComposingId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_DgDeclaration_DgDeclarationId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_EpermitConsignment_EpermitConsignmentId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensor_IotDevice_IotDeviceId",
                table: "Sensor");

            migrationBuilder.DropForeignKey(
                name: "FK_Loading_LoadingActivity_LoadingActivityId",
                table: "Loading");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_LoadingUnit_UldReferenceId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Loading_LoadingId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_PackagingType_PackagingTypeId",
                table: "Piece");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDeclaration_Piece_PieceId",
                table: "SecurityDeclaration");

            migrationBuilder.DropForeignKey(
                name: "FK_RegulatedEntity_SecurityDeclaration_SecurityDeclarationId",
                table: "RegulatedEntity");

            migrationBuilder.DropTable(
                name: "ActivitySequence");

            migrationBuilder.DropTable(
                name: "Adjustments");

            migrationBuilder.DropTable(
                name: "BookingTimes");

            migrationBuilder.DropTable(
                name: "Characteristic");

            migrationBuilder.DropTable(
                name: "CheckExternalReference");

            migrationBuilder.DropTable(
                name: "ContactDetail");

            migrationBuilder.DropTable(
                name: "Context");

            migrationBuilder.DropTable(
                name: "ErrorDetail");

            migrationBuilder.DropTable(
                name: "LogisticsEventCollection");

            migrationBuilder.DropTable(
                name: "Measurement");

            migrationBuilder.DropTable(
                name: "MovementTimes");

            migrationBuilder.DropTable(
                name: "NotificationEventType");

            migrationBuilder.DropTable(
                name: "OperationObject");

            migrationBuilder.DropTable(
                name: "OtherIdentifier");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "PieceProduct");

            migrationBuilder.DropTable(
                name: "PriceRatings");

            migrationBuilder.DropTable(
                name: "Ranges");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropTable(
                name: "ScheduledLegs");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Error");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "Party");

            migrationBuilder.DropTable(
                name: "AccessPermissions");

            migrationBuilder.DropTable(
                name: "TopicType");

            migrationBuilder.DropTable(
                name: "PatchOperation");

            migrationBuilder.DropTable(
                name: "LogisticsAgent");

            migrationBuilder.DropTable(
                name: "AccessDelegation");

            migrationBuilder.DropTable(
                name: "Check");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "BillingDetails");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Geolocation");

            migrationBuilder.DropTable(
                name: "Value");

            migrationBuilder.DropTable(
                name: "BookingRequest");

            migrationBuilder.DropTable(
                name: "BookingOptionRequest");

            migrationBuilder.DropTable(
                name: "CarrierProduct");

            migrationBuilder.DropTable(
                name: "TransportMovement");

            migrationBuilder.DropTable(
                name: "BookingShipment");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "VolumetricWeight");

            migrationBuilder.DropTable(
                name: "BookingOption");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "CO2Emissions");

            migrationBuilder.DropTable(
                name: "CheckTemplate");

            migrationBuilder.DropTable(
                name: "ExternalReference");

            migrationBuilder.DropTable(
                name: "CheckTotalResult");

            migrationBuilder.DropTable(
                name: "CustomsInformation");

            migrationBuilder.DropTable(
                name: "DgRadioactiveIsotope");

            migrationBuilder.DropTable(
                name: "EpermitSignature");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Moving");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Routing");

            migrationBuilder.DropTable(
                name: "Storing");

            migrationBuilder.DropTable(
                name: "TransportLegs");

            migrationBuilder.DropTable(
                name: "Waybill");

            migrationBuilder.DropTable(
                name: "DgProductRadioactive");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Composing");

            migrationBuilder.DropTable(
                name: "UnitComposition");

            migrationBuilder.DropTable(
                name: "DgDeclaration");

            migrationBuilder.DropTable(
                name: "EpermitConsignment");

            migrationBuilder.DropTable(
                name: "LiveAnimalsEpermit");

            migrationBuilder.DropTable(
                name: "IotDevice");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "LoadingMaterial");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "LoadingActivity");

            migrationBuilder.DropTable(
                name: "LoadingUnit");

            migrationBuilder.DropTable(
                name: "Loading");

            migrationBuilder.DropTable(
                name: "TransportMeans");

            migrationBuilder.DropTable(
                name: "PackagingType");

            migrationBuilder.DropTable(
                name: "Piece");

            migrationBuilder.DropTable(
                name: "SecurityDeclaration");

            migrationBuilder.DropTable(
                name: "RegulatedEntity");
        }
    }
}
