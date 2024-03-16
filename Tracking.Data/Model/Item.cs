using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Item")]
public partial class Item : PhysicalLogisticsObject
{

    [DataMember(Name = "cargo:inPiece", EmitDefaultValue = false)]
    public Piece InPiece { get; set; }

    [DataMember(Name = "cargo:ofProduct", EmitDefaultValue = false)]
    public Product OfProduct { get; set; }

    [DataMember(Name = "cargo:dimensions", EmitDefaultValue = false)]
    public Dimensions Dimensions { get; set; }


    [DataMember(Name = "cargo:itemQuantity", EmitDefaultValue = false)]
    public Value ItemQuantity { get; set; }

    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }

    [DataMember(Name = "cargo:productionCountry", EmitDefaultValue = false)]
    public string ProductionCountry { get; set; }

    [DataMember(Name = "cargo:targetCountry", EmitDefaultValue = false)]
    public string TargetCountry { get; set; }

    [DataMember(Name = "cargo:unitPrice", EmitDefaultValue = false)]
    public Value UnitPrice { get; set; }

    [DataMember(Name = "cargo:weight", EmitDefaultValue = false)]
    public Value Weight { get; set; }

    [DataMember(Name = "cargo:batchNumber", EmitDefaultValue = false)]
    public string BatchNumber { get; set; }

    [DataMember(Name = "cargo:expiryDate", EmitDefaultValue = false)]
    public DateTime ExpiryDate { get; set; }

    [DataMember(Name = "cargo:lotNumber", EmitDefaultValue = false)]
    public string LotNumber { get; set; }
    [DataMember(Name = "cargo:quantityForUnitPrice", EmitDefaultValue = false)]
    public double QuantityForUnitPrice { get; set; }

    [DataMember(Name = "cargo:productionDate", EmitDefaultValue = false)]
    public DateTime ProductionDate { get; set; }
    
    //--------
    //[DataMember(Name = "cargo:containedItemInPiece", EmitDefaultValue = false)]
    //public Piece ContainedItemInPiece { get; set; }

    //[DataMember(Name = "cargo:describedByProduct", EmitDefaultValue = false)]
    //public Product DescribedByProduct { get; set; }

    //[DataMember(Name = "cargo:productionCountry", EmitDefaultValue = false)]
    //public Country ProductionCountry { get; set; }

    //[DataMember(Name = "cargo:targetCountry", EmitDefaultValue = false)]
    //public Country TargetCountry { get; set; }
}
