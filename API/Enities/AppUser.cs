using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Enities
{
    public class AppUser
    {
        public int Id { get; set; }

        
        public string UserName { get; set; }

        public byte[] PasswordHash {get; set;}

        public byte[] PasswordSlat {get; set;}
    }
}