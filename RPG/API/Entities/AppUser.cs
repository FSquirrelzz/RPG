using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
        public int ID { get; set;}
        public string UserName { get; set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender {get;set;}
        public DateTime Created {get;set;} = DateTime.Now;
        public DateTime LastActive{get;set;} = DateTime.Now;
        public int ProfessionId{get;set;}
        public Profession Profession{get;set;}
    }
}