using System;
using System.ComponentModel.DataAnnotations;



namespace VirtualCreditCardApi.Model
{
    public class VirtualCreditCard
    {
        [Key]
        public int Id { get; set; }
        
        
        [Required]
        public string NumeroCartaoVirtual{get;set;}
        
        
        //public Cliente cliente{ get; set; }
        
        [ForeignKey("Cliente")]
        public int ClienteID { get; set; }
        
        [Required]
        public DateTime dataCriacao { get; set; }
        
        [Required]
        public DateTime dataExpiracao { get; set; }
    }
}