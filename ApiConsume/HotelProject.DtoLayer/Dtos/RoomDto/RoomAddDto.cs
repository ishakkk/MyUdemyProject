using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numarası Giriniz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Ode Başlığı Bilgisi Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı  Bilgisi Giriniz")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısı Bilgisi Giriniz")]
        public int BathCount { get; set; }
        public string WiFi { get; set; }
        public string Description { get; set; }
    }
}
