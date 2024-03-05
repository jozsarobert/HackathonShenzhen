using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Product")]
public partial class Product : LogisticsObject
{
    [DataMember(Name = "cargo:descriptionForContentOfPieces", EmitDefaultValue = false)]
    public List<Piece> DescriptionForContentOfPieces { get; set; }

    [DataMember(Name = "cargo:descriptionForItems", EmitDefaultValue = false)]
    public List<Item> DescriptionForItems { get; set; }

    [DataMember(Name = "cargo:manufacturer", EmitDefaultValue = false)]
    public Company Manufacturer { get; set; }

    [DataMember(Name = "cargo:otherCharacteristics", EmitDefaultValue = false)]
    public List<Characteristic> OtherCharacteristics { get; set; }

    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }

    [DataMember(Name = "cargo:commodityItemNumber", EmitDefaultValue = false)]
    public string CommodityItemNumber { get; set; }

    [DataMember(Name = "cargo:description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "cargo:hsCode", EmitDefaultValue = false)]
    public string HsCode { get; set; }

    [DataMember(Name = "cargo:hsCommodityDescription", EmitDefaultValue = false)]
    public string HsCommodityDescription { get; set; }

    [DataMember(Name = "cargo:hsCommodityName", EmitDefaultValue = false)]
    public string HsCommodityName { get; set; }

    [DataMember(Name = "cargo:hsType", EmitDefaultValue = false)]
    public string HsType { get; set; }

    [DataMember(Name = "cargo:uniqueIdentifier", EmitDefaultValue = false)]
    public string UniqueIdentifier { get; set; }
}
