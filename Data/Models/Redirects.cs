using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace URLShortener.Data.Models
{
    public class Redirects
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public string Url { get; set; }
        public int Visits { get; set; }

    }
}
