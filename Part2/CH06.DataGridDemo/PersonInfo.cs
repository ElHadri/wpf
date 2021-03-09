using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.DataGridDemo
{
    class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public bool IsEmployed { get; set; }
        public Uri Avatar { get; set; }
    }
}
