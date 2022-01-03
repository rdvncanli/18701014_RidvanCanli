using Microsoft.AspNetCore.Identity;
using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Models
{
    public class Mekan
    {
        public int mekanId { get; set; }

        [Display(Name = "Kategori")]
        public string CatName { get; set; }

        [Display(Name = "Hastalik Adi")]
        public string hastalikAdi { get; set; }

        [Display(Name = "Hastanın Adı")]
        public string hastaninAdi { get; set; }

        [Display(Name = "Hastanın Kimlik Numarası")]
        public string kimlikNo { get; set; }

        [Display(Name = "Hastanın Telefon Numarası")]
        public string numara { get; set; }

        [Display(Name = "Doktor")]
        public string doktor { get; set; }

        [Display(Name = "Hastalık Açıklaması")]
        public string hastalikAciklamasi { get; set; }
       
        [Display(Name = "Hastalık Resmi")]
        public string hastalikResmi { get; set; }

        [Display(Name = "Tarih")]
        public DateTime tarih { get; set; }
        public List<MainComment> MainComments { get; set; }
        public IdentityUser user { get; set; }
    }
}
