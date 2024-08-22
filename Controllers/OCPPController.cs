using OCPPServer;
using Microsoft.AspNetCore.Mvc;
using Services;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OCPPController : ControllerBase
    {
        private readonly OCPPService _ocppService;

        public OCPPController(OCPPService ocppService)
        {
            _ocppService = ocppService ?? throw new ArgumentNullException(nameof(ocppService));
        }

        /// <summary>
        /// Handles incoming OCPP requests and dispatches to the OCPP service.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> HandleRequestAsync([FromBody]OCPPRequest request)
        {
            var response = await _ocppService.HandleRequestAsync(request);
            return Ok(response);
        }

        /// <summary>
        /// Retrieves all OCPP requests.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetRequestsAsync()
        {
            var requests = await _ocppService.GetRequestsAsync();
            return Ok(requests);
        }

        /// <summary>
        /// Retrieves a specific OCPP request by ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestAsync(int id)
        {
            var request = await _ocppService.GetRequestAsync(id);
            return request == null ? NotFound() : Ok(request);
        }

        /// <summary>
        /// Retrieves all OCPP responses.
        /// </summary>
        [HttpGet("responses")]
        public async Task<IActionResult> GetResponsesAsync()
        {
            var responses = await _ocppService.GetResponsesAsync();
            return Ok(responses);
        }

        /// <summary>
        /// Retrieves a specific OCPP response by ID.
        /// </summary>
        [HttpGet("responses/{id}")]
        public async Task<IActionResult> GetResponseAsync(int id)
        {
            var response = await _ocppService.GetResponseAsync(id);
            return response == null ? NotFound() : Ok(response);
        }
    }
}