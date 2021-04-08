using System;
using System.Collections.Generic;

namespace EFProject.Model
{
    class User
    {
        public int IdUser { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNamber { set; get; }
        public string Password { get; set; }
        public DateTime Birthday { set; get; }
        public int Role { set; get; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
