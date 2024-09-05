using ContactsControl.Models;

namespace ContactsControl.Repository
{
    public interface IContactRepository
    {
        ContactModel Add(ContactModel contact);
    }
}