using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Whatsapp { get; set; }
        public string Mail { get; set; }
        public string MapLacation { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string YoutubeLink { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
    }
}
