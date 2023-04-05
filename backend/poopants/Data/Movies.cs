using System.ComponentModel.DataAnnotations;

namespace poopants.Data
{
    public class Movies
    {
        //creating the movie model
        [Key]
        public int MovieId { get; set; }
        public string? title { get; set; }
        public string? category { get; set; }
        public int? year { get; set; }
        public string? director { get; set; }
        public string? rating { get; set; }
        public string? edited { get; set; }
        public string? lentto { get; set; }
        public string? notes { get; set; }
    }

}
