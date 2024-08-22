public class OCPPResponse
{
    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public object Payload { get; set; }

    public OCPPResponse() { }

    public OCPPResponse(int statusCode, string statusMessage, object payload)
    {
        StatusCode = statusCode;
        StatusMessage = statusMessage;
        Payload = payload;
    }
}

public static class OCPPResponseFactory
{
    public static OCPPResponse CreateSuccessResponse(object payload)
    {
        return new OCPPResponse(200, "Success", payload);
    }

    public static OCPPResponse CreateErrorResponse(string errorMessage)
    {
        return new OCPPResponse(500, errorMessage, null);
    }
}

public enum OCPPResponseStatus
{
    Success = 200,
    Error = 500
}

public interface IOCPPResponse 
{
    int StatusCode { get; set; }
    string StatusMessage { get; set; }
    object Payload { get; set; }
}