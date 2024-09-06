using ContactsControl.Models;

namespace ContactsControl.Repository
{
    public interface IContactRepository
    {
        ContactModel ListById(int id);
        List<ContactModel> FetchAll();
        ContactModel Add(ContactModel contact);
        ContactModel Update(ContactModel contact);
    }
}