using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace URLShortener.Data.Models
{
    public class Referrals
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public int Visits { get; set; }

    }
}
