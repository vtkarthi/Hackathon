using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VzSoftphone.Models;

namespace VzSoftphone.Controllers
{
    public class mcController : ApiController
    {
       
        [HttpGet]
        public IHttpActionResult GetAgents(int id)
        {


            List<call> liCall = new List<call>();
            using (SqlConnection connection = new SqlConnection("Data Source=SCSBWIN-398215;Initial Catalog=CallEvents;Persist Security Info=True;User ID=sa;Password=Admin123;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AgentRealtimeInfo", connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            call p = new call();
                            // To avoid unexpected bugs access columns by name.
                            p.AgentId = reader.GetInt32(reader.GetOrdinal("AgentId"));
                           DateTime dSt= p.StatusTimestamp = reader.GetDateTime(reader.GetOrdinal("StatusTimestamp"));
                           p.Duration =(DateTime.Now - dSt).ToString();
                           liCall.Add(p);
                        }
                    }
                }
            }

            if (liCall == null)
            {
                return NotFound();
            }
            return Ok(liCall);
        }
    }
    
}
