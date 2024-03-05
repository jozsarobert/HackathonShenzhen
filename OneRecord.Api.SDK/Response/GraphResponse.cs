using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OneRecord.Api.SDK.Response;

public class GraphResponse
{
    [JsonProperty("@graph")]
    public List<Object> Objects { get; set; }
}
