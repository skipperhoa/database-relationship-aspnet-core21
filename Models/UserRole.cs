using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationshipCoreFirst_ASPcore.Models
{
    public class UserRole
    {
        public int idUser { get; set; }
        public int idRole { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
