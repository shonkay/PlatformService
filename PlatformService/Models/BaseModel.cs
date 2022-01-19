using System;

namespace PlatformService.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Isdeleted { get; set; }
    }
}
