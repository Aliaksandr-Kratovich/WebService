using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceApp.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }
    }
}
