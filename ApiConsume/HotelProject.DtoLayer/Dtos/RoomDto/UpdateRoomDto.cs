using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazın")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli girin")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi yazın")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığını  yazın")]
        [StringLength(100,ErrorMessage = " Lütfen en fazla 100 karakter girişi yapın")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını yazın")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını yazın")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı girin yazın")]
        public string Description { get; set; }
    }
}
