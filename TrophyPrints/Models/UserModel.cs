using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrophyPrints.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } //Check if string appropriate for password
    }
}
