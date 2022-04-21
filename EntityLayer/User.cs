using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreLayer.Interface;

namespace EntityLayer
{
    public class User : IEntity
    {
       
        public string Id { get; set; }
        [MaxLength(100)]
        public string EmailAdress { get; set; } = "";      
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
