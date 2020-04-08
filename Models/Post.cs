using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationshipCoreFirst_ASPcore.Models
{
    public class Post
    {
        public int idPost { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int idUser { get; set; }
        public User User { get; set; }
    }
}
