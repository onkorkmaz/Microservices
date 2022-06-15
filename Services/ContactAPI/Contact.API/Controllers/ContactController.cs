using Contact.API.Infrastructure;
using Contact.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO Contact(int id)
        {
            return contactService.GetContactById(id);
        }
    }
}
