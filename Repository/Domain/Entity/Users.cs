using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o login do usuário.")]
        [Display(Name = "Usuário")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Informe o email do usuário.")]
        public string Email { get; set; }
    }
}
