using ContactsControl.Models;

namespace ContactsControl.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> FetchAll();
        ContactModel Add(ContactModel contact);
    }
}