using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string SenderUsername { get; set; }
        public string ResiverUsername { get; set; }
        public string Text { get; set; }
        public DateTime time { get; set; }
        [DefaultValue(false)]
        public bool read { get; set; }
       
        public string userid { get; set; }
        public virtual User user { get; set; }


    }
}
