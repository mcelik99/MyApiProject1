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
        [Required(ErrorMessage ="Lütfen oda numarasını yazın")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi yazın")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığını  yazın")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını yazın")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını yazın")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
