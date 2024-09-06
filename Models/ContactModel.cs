using System.ComponentModel.DataAnnotations;

namespace ContactsControl.Models
{
    public class ContactModel
    {
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Name {get; set;}
        
        [Required(ErrorMessage = "Digite o E-mail do contato")]
        [EmailAddress(ErrorMessage = "O E-mail informado não é valido")]
        public string Email  {get; set;}
        
        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage = "O celular informado não é valido")]
        public string CellPhone  {get; set;}
    }
}
