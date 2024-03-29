/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://openapi-generator.tech
 */

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using Reelables.Api.Fake.Attributes;
using Reelables.Api.Fake.Models;

namespace Reelables.Api.Fake.Controllers;

/// <summary>
/// 
/// </summary>
[ApiController]
public class AssetLabelsApiController : ControllerBase
{ 
    /// <summary>
    /// Unlink a Label from an Asset
    /// </summary>
    /// <param name="assetId">The identifier of the Asset</param>
    /// <param name="bleId">The identifier of the Label</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
    /// <response code="200">200 response</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="403">Forbidden</response>
    /// <response code="404">Asset not found</response>
    /// <response code="429">Too Many Requests</response>
    [HttpDelete]
    [Route("/v1/assets/{assetId}/labels/{bleId}")]
    [ValidateModelState]
    [SwaggerOperation("AssetsAssetIdLabelsBleIdDelete")]
    [SwaggerResponse(statusCode: 200, type: typeof(Asset), description: "200 response")]
    [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
    [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
    [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Asset not found")]
    [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
    public virtual IActionResult AssetsAssetIdLabelsBleIdDelete([FromRoute (Name = "assetId")][Required]string assetId, [FromRoute (Name = "bleId")][Required]string bleId, [FromHeader (Name = "request-id")]string requestId)
    {

        //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200, default(Asset));
        //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(401, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(403, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(404, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(429, default(ErrorResponse));
        string exampleJson = null;
        exampleJson = "{\r\n  \"inSpaces\" : [ {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"temperatures\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    } ]\r\n  },\r\n  \"name\" : \"name\",\r\n  \"locations\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"id\" : \"id\",\r\n  \"label\" : {\r\n    \"bleId\" : 494379917,\r\n    \"nfcId\" : \"nfcId\",\r\n    \"addedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"workspaceId\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
        var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Asset>(exampleJson)
            : default(Asset);
        //TODO: Change the data returned
        return new ObjectResult(example);
    }

    /// <summary>
    /// Link a Label to an Asset
    /// </summary>
    /// <param name="assetId">The identifier of the Asset</param>
    /// <param name="assetLabelInput"></param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
    /// <response code="200">200 response</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="403">Forbidden</response>
    /// <response code="404">Asset not found</response>
    /// <response code="429">Too Many Requests</response>
    [HttpPost]
    [Route("/v1/assets/{assetId}/labels")]
    [Consumes("application/json")]
    [ValidateModelState]
    [SwaggerOperation("AssetsAssetIdLabelsPost")]
    [SwaggerResponse(statusCode: 200, type: typeof(Asset), description: "200 response")]
    [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
    [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
    [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Asset not found")]
    [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
    public virtual IActionResult AssetsAssetIdLabelsPost([FromRoute (Name = "assetId")][Required]string assetId, [FromBody]AssetLabelInput assetLabelInput, [FromHeader (Name = "request-id")]string requestId)
    {

        //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200, default(Asset));
        //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(401, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(403, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(404, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(429, default(ErrorResponse));
        string exampleJson = null;
        exampleJson = "{\r\n  \"inSpaces\" : [ {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"spaceName\" : \"spaceName\",\r\n    \"spaceId\" : \"spaceId\",\r\n    \"hasExited\" : true,\r\n    \"enteredOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"exitedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"temperatures\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    }, {\r\n      \"degreesCelcius\" : -51.95031,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"numberReadings\" : 602745\r\n    } ]\r\n  },\r\n  \"name\" : \"name\",\r\n  \"locations\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"id\" : \"id\",\r\n  \"label\" : {\r\n    \"bleId\" : 494379917,\r\n    \"nfcId\" : \"nfcId\",\r\n    \"addedOn\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"workspaceId\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
        var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Asset>(exampleJson)
            : default(Asset);
        //TODO: Change the data returned
        return new ObjectResult(example);
    }
}