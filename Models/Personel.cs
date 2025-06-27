using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Personel
    {
        [Required(ErrorMessage = "Personel No Girin")]
        [StringLength(10, ErrorMessage = "Personel No Hatalı")]
        public string? Id { get; set; }

        [Required(ErrorMessage = "İsim Girin")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Cinsiyet Seçin")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Departman Seçin")]
        public string? Department { get; set; }


        [Required(ErrorMessage = "Maaş Girin")]
        [Range(1, 1000000, ErrorMessage = "Maaş Hatalı")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Ehliyet Zorunlu")]
        public bool DrivingLicence { get; set; }

        [Required(ErrorMessage = "Askerlik Zorunlu")]
        public bool MilitaryService { get; set; }
        [Required(ErrorMessage = "Doğum Tarihi Seçin")]
        public DateTime BirthDate { get; set; }

        public string? Description { get; set; }
    }
}