using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OktaWebApiApp.Models
{
    public class OktaResponseModel
    {
        public List<Command> commands { get; set; }
        public Error error { get; set; }

        public class Command
        {
            public string type { get; set; }
            public Value value { get; set; }
        }

        public class Value
        {
            public string registration { get; set; }
        }

        public class Error
        {
            public string errorSummary { get; set; }
            public Errorcause[] errorCauses { get; set; }
        }

        public class Errorcause
        {
            public string errorSummary { get; set; }
            public string reason { get; set; }
            public string locationType { get; set; }
            public string location { get; set; }
            public string domain { get; set; }
        }

    }
}

