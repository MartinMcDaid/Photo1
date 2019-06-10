using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public class ContactService : IContactRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContactService(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public void AddContact(Contact contact)
        {
            _appDbContext.Contacts.Add(contact);
            _appDbContext.SaveChanges();
        }
    }
}
