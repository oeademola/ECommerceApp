using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "Bad Request, the server could not understand the request due to invalid syntax.",
                401 => "Unauthorized, client authentication failed.",
                404 => "Not Found, the server could not find the requested resource.",
                500 => "Internal Server Error, the server encountered an unexpected condition which prevented it from fulfilling the request.",
                _ => null
            };
        }
    }
}