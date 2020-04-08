using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationshipCoreFirst_ASPcore.Models
{
    public class User
    {
        public int idUser { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
