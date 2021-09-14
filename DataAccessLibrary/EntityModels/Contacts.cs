using System;
using System.Collections.Generic;

namespace ReactJs_Redux_01.EntityModels
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
