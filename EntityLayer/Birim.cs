using CoreLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Birim:IEntity
    {
      
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string BirimAdi { get; set; } = "";
        public ICollection<Personel> Personeller { get; set; }
    }
}
