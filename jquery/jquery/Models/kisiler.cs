using System.ComponentModel.DataAnnotations;

namespace jquery.Models
{
    public class kisiler
    {
        [Key]
        public int Kisi_id { get; set; }
        public string kisi_isim { get; set; }
        public string kisi_soyad { get; set; }
        public int kisi_yas { get; set; }
    }
}
