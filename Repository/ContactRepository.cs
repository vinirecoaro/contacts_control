using ContactsControl.Data;
using ContactsControl.Models;

namespace ContactsControl.Repository
{
    public class ContactRepository : IContactRepository
    {

        private readonly DatabaseContext _databaseContext;

        public ContactRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ContactModel Add(ContactModel contact)
        {
            _databaseContext.Contacts.Add(contact);
            _databaseContext.SaveChanges();
            return contact;
        }
    }


}