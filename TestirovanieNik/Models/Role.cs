using System;
using System.Collections.Generic;

namespace TestirovanieNik.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string NameRole { get; set; } = null!;
        public int LevelDostup { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
