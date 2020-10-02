using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;

namespace Gym_Service.Controllers
{
    public class GymAPIController : ApiController
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        // GET: api/GymAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public void connectionString()
        {
            con.ConnectionString = "";
        }

        // GET: api/GymAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GymAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GymAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GymAPI/5
        public void Delete(int id)
        {
        }
    }
}
