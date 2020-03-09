﻿namespace Intercom.Service.FingerprintBuilder.Tests.Models
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }


    public class ExtendedUser : User
    {
        public string[] Emails { get; set; }
    }
}