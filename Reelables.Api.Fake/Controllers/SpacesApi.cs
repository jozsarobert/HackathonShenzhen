/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Org.OpenAPITools.Attributes;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SpacesApiController : ControllerBase
    { 
        /// <summary>
        /// Delete a Space
        /// </summary>
        /// <param name="spaceId">The identifier of the Space</param>
        /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
        /// <response code="204">204 response</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Space not found</response>
        /// <response code="429">Too Many Requests</response>
        [HttpDelete]
        [Route("/v1/spaces/{spaceId}")]
        [ValidateModelState]
        [SwaggerOperation("SpacesSpaceIdDelete")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Space not found")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        public virtual IActionResult SpacesSpaceIdDelete([FromRoute (Name = "spaceId")][Required]string spaceId, [FromHeader (Name = "request-id")]string requestId)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);
            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429, default(ErrorResponse));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a Space
        /// </summary>
        /// <param name="spaceId">The identifier of the Space</param>
        /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
        /// <response code="200">200 response</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Space not found</response>
        /// <response code="429">Too Many Requests</response>
        [HttpGet]
        [Route("/v1/spaces/{spaceId}")]
        [ValidateModelState]
        [SwaggerOperation("SpacesSpaceIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Space), description: "200 response")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Space not found")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        public virtual IActionResult SpacesSpaceIdGet([FromRoute (Name = "spaceId")][Required]string spaceId, [FromHeader (Name = "request-id")]string requestId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Space));
            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"numberAssetsInSpace\" : 80082,\r\n  \"name\" : \"name\",\r\n  \"locations\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"id\" : \"id\",\r\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"gateway\" : {\r\n    \"isStatic\" : true,\r\n    \"latitude\" : 18.494211,\r\n    \"hasPendingCommands\" : true,\r\n    \"rssiFilter\" : \"FAR\",\r\n    \"gatewayId\" : \"gatewayId\",\r\n    \"addedOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"longitude\" : -127.230736\r\n  },\r\n  \"workspaceId\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Space>(exampleJson)
            : default(Space);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a Space
        /// </summary>
        /// <param name="spaceId">The identifier of the Space</param>
        /// <param name="spaceInput"></param>
        /// <param name="requestId">Unique identifier for the API request. Example: f7ecf495-ca1c-4468-a6c2-6ee3f723fa00</param>
        /// <response code="200">200 response</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Space not found</response>
        /// <response code="429">Too Many Requests</response>
        [HttpPut]
        [Route("/v1/spaces/{spaceId}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("SpacesSpaceIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Space), description: "200 response")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Space not found")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        public virtual IActionResult SpacesSpaceIdPut([FromRoute (Name = "spaceId")][Required]string spaceId, [FromBody]SpaceInput spaceInput, [FromHeader (Name = "request-id")]string requestId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Space));
            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));
            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"numberAssetsInSpace\" : 80082,\r\n  \"name\" : \"name\",\r\n  \"locations\" : {\r\n    \"nextToken\" : \"nextToken\",\r\n    \"items\" : [ {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"coordinate\" : {\r\n        \"latitude\" : -63.615368,\r\n        \"longitude\" : 34.63682\r\n      },\r\n      \"error\" : 563737,\r\n      \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ]\r\n  },\r\n  \"id\" : \"id\",\r\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"gateway\" : {\r\n    \"isStatic\" : true,\r\n    \"latitude\" : 18.494211,\r\n    \"hasPendingCommands\" : true,\r\n    \"rssiFilter\" : \"FAR\",\r\n    \"gatewayId\" : \"gatewayId\",\r\n    \"addedOn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"longitude\" : -127.230736\r\n  },\r\n  \"workspaceId\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            exampleJson = "{\r\n  \"errors\" : [ {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"code\" : \"code\",\r\n    \"id\" : \"id\",\r\n    \"detail\" : \"detail\",\r\n    \"title\" : \"title\",\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Space>(exampleJson)
            : default(Space);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
