using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Models
{
    public class User : IUser
    {
        public int Id { get; set; }

        public string Username { get; set; }
    }
}
