using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Model
{
    public class ContactDTO
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
