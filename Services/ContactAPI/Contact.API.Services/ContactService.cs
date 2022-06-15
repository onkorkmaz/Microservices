using Contact.API.Infrastructure;
using Contact.API.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO()
            {
                ID = id,
                FirstName = "Onur",
                LastName = "KORKMAZ"
            };
        }
    }
}
