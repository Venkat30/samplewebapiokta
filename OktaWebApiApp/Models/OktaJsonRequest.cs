﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OktaWebApiApp.Models
{
    public class OktaJsonRequest
    {
        public string eventId { get; set; }
        public DateTime eventTime { get; set; }
        public string eventType { get; set; }
        public string eventTypeVersion { get; set; }
        public string contentType { get; set; }
        public string cloudEventVersion { get; set; }
        public string source { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public Context context { get; set; }
            public Userprofile userProfile { get; set; }
            public object action { get; set; }
        }

        public class Context
        {
            public Request request { get; set; }
        }

        public class Request
        {
            public string id { get; set; }
            public string method { get; set; }
            public Url url { get; set; }
            public string ipAddress { get; set; }
        }

        public class Url
        {
            public string value { get; set; }
        }

        public class Userprofile
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string login { get; set; }
            public string email { get; set; }
        }

    }
}