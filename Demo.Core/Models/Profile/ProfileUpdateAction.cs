﻿using System;
namespace Demo.Core.Models.Profile
{
    public class ProfileUpdateAction
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool SendPush { get; set; }
    }
}
