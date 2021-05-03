using System.ComponentModel.DataAnnotations.Schema;

namespace WebServiceApi.Models
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
