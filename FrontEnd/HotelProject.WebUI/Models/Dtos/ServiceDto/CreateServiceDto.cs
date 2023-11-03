using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage ="Servis İkon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Servis Başlığı Giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Servis Açıklaması Giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]
        public string Description { get; set; }
    }
}
