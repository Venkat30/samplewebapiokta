using Newtonsoft.Json;
using OktaWebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using static OktaWebApiApp.Models.OktaResponseModel;
using static OktaWebApiApp.Models.OktaUserProfile;

namespace OktaWebApiApp.Controllers
{
    public class ValuesController : ApiController
    {

        List<string> values = new List<string>
        {
            "value1", "value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] string value)
        {
            //values.Add(value);

            //List<Command> commands = new List<Command>();
            //Value valueModel = new Value();
            //valueModel.registration = "ALLOW";
            //Command command = new Command();
            //command.type = "com.okta.action.update";
            //command.value = valueModel;
            //commands.Add(command);
            //OktaResponseModel oktaResponseModel = new OktaResponseModel();
            //oktaResponseModel.commands = commands;

            //string allText = System.IO.File.ReadAllText(@"D:\Venkat\Demo_Projects\SampleOktaWebApiApp\SampleOktaWebApiApp\App_Data\error.json");

            //object jsonObject = JsonConvert.DeserializeObject(allText);

            /// Update user profile
            /// 
            //List<Command> commands = new List<Command>();
            //Value valueModel = new Value();
            //valueModel.customerId = "Hexagon" + (string.IsNullOrEmpty(userProfile.lastName) ? "MyOwnString" : userProfile.lastName);
            //valueModel.customerId = "Hexagon";
            //Command command = new Command();
            //command.type = "com.okta.user.profile.update";
            //command.value = valueModel;
            //commands.Add(command);
            //OktaResponseModel oktaResponseModel = new OktaResponseModel();
            //oktaResponseModel.commands = commands;

            //List<Command> commands = new List<Command>();
            //Value valueModel = new Value();
            //valueModel.customerId = "Hexagon" + (string.IsNullOrEmpty(data.data.userProfile.lastName) ? "MyOwnString" : data.data.userProfile.lastName);
            //Command command = new Command();
            //command.type = "com.okta.user.profile.update";
            //command.value = valueModel;
            //commands.Add(command);
            //OktaResponseModel oktaResponseModel = new OktaResponseModel();
            //oktaResponseModel.commands = commands;

            return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
