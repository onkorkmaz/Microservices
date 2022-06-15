using Contact.API.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int Id);
    }
}
