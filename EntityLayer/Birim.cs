using CoreLayer.Interface;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Birim:IEntity
    {
      
        public string Id { get; set; }
        [MaxLength(50)]
        public string BirimAdi { get; set; } = "";
        public ICollection<Personel>? Personeller { get; set; }
    }
}
