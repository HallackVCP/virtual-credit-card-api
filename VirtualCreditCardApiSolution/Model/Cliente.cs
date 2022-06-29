using System.ComponentModel.DataAnnotations;

namespace VirtualCreditCardApi.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string email { get; set; }
        
        [Required]
        
        public string cpf { get; set; }
    }
}