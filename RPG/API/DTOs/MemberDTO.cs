using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDTO
    {
        public int ID { get; set;}
        public string Username { get; set;}
        public string Gender {get;set;}
        public DateTime Created {get;set;} = DateTime.Now;
        public DateTime LastActive{get;set;} = DateTime.Now;
        public string ProfessionName{get;set;}
        public int ProfessionId{get;set;}
    }
}