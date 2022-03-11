using System.Net;

namespace PlatformService.Models
{
    public class ResponseModel
    {
        public string ResponseMessage { get; set; }
        public object ResponseObject { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
    }
}
