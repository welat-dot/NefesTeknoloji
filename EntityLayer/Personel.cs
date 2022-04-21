using CoreLayer.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Personel : IEntity
    {
        
        public string Id { get; set; }
        [MaxLength(50)]
        public string Adi { get; set; } = "";
        [MaxLength(50)]
        public string SoyAdi { get; set; } = "";
        public string BirimId { get; set; } 
        public Birim? Birim { get; set; }

    }
}
