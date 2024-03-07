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
public class FacilitiesApiController : ControllerBase
{ 
    /// <summary>
    /// Get a Facility
    /// </summary>
    /// <param name="facilityId">The identifier of the Facility</param>
    /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
    /// <response code="200">200 response</response>
    /// <response code="401">Unauthorized</response>
    /// <response code="403">Forbidden</response>
    /// <response code="404">Facility not found</response>
    /// <response code="429">Too Many Requests</response>
    [HttpGet]
    [Route("/v1/facilities/{facilityId}")]
    [ValidateModelState]
    [SwaggerOperation("FacilitiesFacilityIdGet")]
    [SwaggerResponse(statusCode: 200, type: typeof(Facility), description: "200 response")]
    [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
    [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
    [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Facility not found")]
    [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
    public virtual IActionResult FacilitiesFacilityIdGet([FromRoute (Name = "facilityId")][Required]string facilityId, [FromHeader (Name = "request-id")]string requestId)
    {

        //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(200, default(Facility));
        //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(401, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(403, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(404, default(ErrorResponse));
        //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        // return StatusCode(429, default(ErrorResponse));
        string exampleJson = null;
        exampleJson = "{\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"workspaceId\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"userFacilityId\" : \"userFacilityId\"\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
        exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
        var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Facility>(exampleJson)
            : default(Facility);
        //TODO: Change the data returned
        return new ObjectResult(example);
    }
}