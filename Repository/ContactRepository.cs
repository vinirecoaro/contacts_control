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

        public ContactModel ListById(int id)
        {
            return _databaseContext.Contacts.FirstOrDefault(x => x.Id == id);
        }

        public List<ContactModel> FetchAll()
        {
            return _databaseContext.Contacts.ToList();
        }

        public ContactModel Add(ContactModel contact)
        {
            _databaseContext.Contacts.Add(contact);
            _databaseContext.SaveChanges();
            return contact;
        }

        public ContactModel Update(ContactModel contact)
        {
            ContactModel contactDB = ListById(contact.Id);
            
            if(contactDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            contactDB.Name = contact.Name;
            contactDB.Email = contact.Email;
            contactDB.CellPhone = contact.CellPhone;

            _databaseContext.Contacts.Update(contactDB);
            _databaseContext.SaveChanges();

            return contactDB;

        }
    }


}