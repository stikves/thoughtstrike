using System.ComponentModel.DataAnnotations;

namespace Ideastrike.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}