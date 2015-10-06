/*
 * 
 * 
 * Added by Ranjith Kumar*/ 

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
       [Route("api/live")]
        [HttpGet]        
        public IHttpActionResult GetAgents()
        {

            //string con = "Data Source=113.128.163.79,1433;Network Library=DBMSSOCN;Initial Catalog=CallEvents;User ID=sa;Password=Admin123;";
            string con = "Data Source=SCSBWIN-398215;Initial Catalog=CallEvents;Persist Security Info=True;User ID=sa;Password=Admin123;MultipleActiveResultSets=True;Application Name=EntityFramework";
            List<call> liCall = new List<call>();
            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AgentRealtimeInfo", connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        int pic = 1;
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            call p = new call();
                            // To avoid unexpected bugs access columns by name.
                            p.AgentId = reader.GetInt32(reader.GetOrdinal("AgentId"));
                           DateTime dSt= p.StatusTimestamp = reader.GetDateTime(reader.GetOrdinal("StatusTimestamp"));
                           p.Duration =(DateTime.Now - dSt).ToString();
                           p.photo = "a" + ((++pic % 4)+1) + ".jpg";
                           p.AgentStatus = reader.GetString(reader.GetOrdinal("AgentStatus"));
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

        [Route("api/all")]
        [HttpGet]        
        public IHttpActionResult GetReport()
        {


            List<call> liCall = new List<call>();
            using (SqlConnection connection = new SqlConnection("Data Source=SCSBWIN-398215;Initial Catalog=CallEvents;Persist Security Info=True;User ID=sa;Password=Admin123;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) as count,AgentStatus  FROM AgentRealtimeInfo group by AgentStatus", connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        int pic = 1;
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            call p = new call();
                            // To avoid unexpected bugs access columns by name.
                            p.AgentRealtimeInfoId = pic++;
                            p.AgentId = reader.GetInt32(reader.GetOrdinal("count"));
                            p.AgentStatus = reader.GetString(reader.GetOrdinal("AgentStatus"));

                            //p.StatusTimestamp = reader.GetDateTime(reader.GetOrdinal("StatusTimestamp"));

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
