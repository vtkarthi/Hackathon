using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VzSoftphone.Models
{
    public class call
    {
        //public int AgentRealtimeInfoId { get; set; }
        public int AgentId { get; set; }
        //public string AgentStatus { get; set; }
        public DateTime StatusTimestamp { get; set; }
        public string Duration { get; set; }       

    }
}