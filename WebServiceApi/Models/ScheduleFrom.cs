using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebServiceApi.Models
{
    [Table("schedule_form")]
    public class ScheduleForm : BaseEntity
    {

        [Column("first_name")]
        [Required]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Column("last_name")]
        [Required]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Column("email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column("address")]
        [Required]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Column("phone")]
        [Required]
        [Display(Name = "Celular")]
        public string Phone { get; set; }

        [Column("service")]
        [Required]
        [Display(Name = "Serviço")]
        public int Service { get; set; }

        [Column("date")]
        [Required]
        [Display(Name = "Data e horário")]
        public DateTime Date { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        public ScheduleForm()
        {

        }
        public TypeServices GetService(int service)
        {
            return (TypeServices)ServiceTypeWrapper.ServiceTypeById(service);
        }

        public void SetService(TypeServices types)
        {
            this.Service = types.GetHashCode();
        }
    }
}

