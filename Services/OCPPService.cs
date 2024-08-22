using OCPPServer;
using Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class OCPPService
    {
        private readonly OCPPDatabaseContext _context;

        public OCPPService(OCPPDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Models.IOcppResponse> HandleRequestAsync(Models.OCPPRequest request)
        {
            try
            {
                // Save the request to the database
                _context.OCPPRequests.Add(request);
                await _context.SaveChangesAsync();

                // Implement OCPP 2.0.1 protocol logic here
                // For demonstration purposes, a simple success response is returned
                return Models.OCPPResponseFactory.CreateSuccessResponse(new { Message = "Request received successfully" });
            }
            catch (Exception ex)
            {
                // Log the error and return an error response
                return Models.OCPPResponseFactory.CreateErrorResponse(ex.Message);
            }
        }

        public async Task<List<Models.OCPPRequest>> GetRequestsAsync()
        {
            return await _context.OCPPRequests.ToListAsync();
        }

        public async Task<Models.OCPPRequest> GetRequestAsync(int id)
        {
            return await _context.OCPPRequests.FindAsync(id);
        }

        public async Task<List<Models.OCPPResponse>> GetResponsesAsync()
        {
            return await _context.OCPPResponses.ToListAsync();
        }

        public async Task<Models.OCPPResponse> GetResponseAsync(int id)
        {
            return await _context.OCPPResponses.FindAsync(id);
        }
    }
}