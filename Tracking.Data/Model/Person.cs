using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Person")]
public partial class Person : Actor
{
    [DataMember(Name = "cargo:contactDetails", EmitDefaultValue = false)]
    public List<ContactDetail> ContactDetails { get; set; }

    [DataMember(Name = "cargo:documents", EmitDefaultValue = false)]
    public List<ExternalReference> Documents { get; set; }

    [DataMember(Name = "cargo:contactRole", EmitDefaultValue = false)]
    public string ContactRole { get; set; }

    [DataMember(Name = "cargo:department", EmitDefaultValue = false)]
    public string Department { get; set; }

    [DataMember(Name = "cargo:employeeId", EmitDefaultValue = false)]
    public string EmployeeId { get; set; }

    [DataMember(Name = "cargo:firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }

    [DataMember(Name = "cargo:jobTitle", EmitDefaultValue = false)]
    public string JobTitle { get; set; }

    [DataMember(Name = "cargo:lastName", EmitDefaultValue = false)]
    public string LastName { get; set; }

    [DataMember(Name = "cargo:middleName", EmitDefaultValue = false)]
    public string MiddleName { get; set; }

    [DataMember(Name = "cargo:salutation", EmitDefaultValue = false)]
    public string Salutation { get; set; }
}
