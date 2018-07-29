﻿using JsonFx.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindle_viewer.Model
{
    class HttpDataModel
    {
        public class AuthRequest
        {
            [JsonName("email")]
            public string Email { get; set; }
            [JsonName("pwd")]
            public string Pwd { get; set; }
            [JsonName("avatarUrl")]
            public string AvatarUrl { get; set; }
        }
    }
}