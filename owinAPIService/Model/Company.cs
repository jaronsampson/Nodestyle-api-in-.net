using System.ComponentModel.DataAnnotations;

namespace owinAPIService.Model
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
