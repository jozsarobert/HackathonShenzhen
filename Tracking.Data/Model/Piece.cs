using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Piece")]
public partial class Piece : PhysicalLogisticsObject
{
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:containedItems", EmitDefaultValue = false)]
    public List<Item> ContainedItems { get; set; }

    [DataMember(Name = "cargo:containedPieceInPiece", EmitDefaultValue = false)]
    public Piece ContainedPieceInPiece { get; set; }

    [DataMember(Name = "cargo:containedPieces", EmitDefaultValue = false)]
    public List<Piece> ContainedPieces { get; set; }

    [DataMember(Name = "cargo:contentDescribedByProducts", EmitDefaultValue = false)]
    public List<Product> ContentDescribedByProducts { get; set; }

    [DataMember(Name = "cargo:contentProductionCountry", EmitDefaultValue = false)]
    public Country ContentProductionCountry { get; set; }

    [DataMember(Name = "cargo:customsInformation", EmitDefaultValue = false)]
    public List<CustomsInformation> CustomsInformation { get; set; }

    [DataMember(Name = "cargo:dimensions", EmitDefaultValue = false)]
    public Dimensions Dimensions { get; set; }

    [DataMember(Name = "cargo:grossWeight", EmitDefaultValue = false)]
    public Value GrossWeight { get; set; }

    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    public List<Party> InvolvedParties { get; set; }

    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }

    [DataMember(Name = "cargo:packagingType", EmitDefaultValue = false)]
    public PackagingType PackagingType { get; set; }

    [DataMember(Name = "cargo:partOfShipment", EmitDefaultValue = false)]
    public Shipment PartOfShipment { get; set; }

    [DataMember(Name = "cargo:securityDeclaration", EmitDefaultValue = false)]
    public SecurityDeclaration SecurityDeclaration { get; set; }

    [DataMember(Name = "cargo:uldReference", EmitDefaultValue = false)]
    public LoadingUnit UldReference { get; set; }

    [DataMember(Name = "cargo:volumetricWeight", EmitDefaultValue = false)]
    public VolumetricWeight VolumetricWeight { get; set; }

    [DataMember(Name = "cargo:coload", EmitDefaultValue = true)]
    public bool Coload { get; set; }

    [DataMember(Name = "cargo:declaredValueForCarriage", EmitDefaultValue = false)]
    public string DeclaredValueForCarriage { get; set; }

    [DataMember(Name = "cargo:declaredValueForCustoms", EmitDefaultValue = false)]
    public string DeclaredValueForCustoms { get; set; }

    [DataMember(Name = "cargo:fulfillsUldTypeCode", EmitDefaultValue = false)]
    public string FulfillsUldTypeCode { get; set; }

    [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
    public string GoodsDescription { get; set; }

    [DataMember(Name = "cargo:loadType", EmitDefaultValue = false)]
    public string LoadType { get; set; }

    [DataMember(Name = "cargo:nvdForCarriage", EmitDefaultValue = true)]
    public bool NvdForCarriage { get; set; }

    [DataMember(Name = "cargo:nvdForCustoms", EmitDefaultValue = true)]
    public bool NvdForCustoms { get; set; }

    [DataMember(Name = "cargo:packageMarkCoded", EmitDefaultValue = false)]
    public string PackageMarkCoded { get; set; }

    [DataMember(Name = "cargo:packagedeIdentifier", EmitDefaultValue = false)]
    public string PackagedeIdentifier { get; set; }

    [DataMember(Name = "cargo:shippingMarks", EmitDefaultValue = false)]
    public List<string> ShippingMarks { get; set; }

    [DataMember(Name = "cargo:slac", EmitDefaultValue = false)]
    public int Slac { get; set; }

    [DataMember(Name = "cargo:stackable", EmitDefaultValue = true)]
    public bool Stackable { get; set; }

    [DataMember(Name = "cargo:turnable", EmitDefaultValue = true)]
    public bool Turnable { get; set; }

    [DataMember(Name = "cargo:upid", EmitDefaultValue = false)]
    public string Upid { get; set; }
}

