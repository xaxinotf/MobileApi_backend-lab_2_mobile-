using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileApi.Models;

namespace MobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly MobileAppDbContext _context;

        public ContactsController(MobileAppDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-contacts")]
        public async Task<ActionResult> GetContacts()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return Ok(contacts);
        }

        [HttpGet("get-sample-contacts")]
        public async Task<ActionResult> GetSampleContacts()
        {
            var contactsWithoutKnuEmail = await _context.Contacts.Where(contact => !contact.Email.EndsWith("@knu.ua")).ToListAsync();
            return Ok(contactsWithoutKnuEmail);
        }
    }
}
