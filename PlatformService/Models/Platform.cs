﻿using System;

namespace PlatformService.Models
{
    public class Platform : BaseModel
    {
        public string PlatformName { get; set; }
        public string Publisher { get; set; }
        public string Cost { get; set; }
    }
}
