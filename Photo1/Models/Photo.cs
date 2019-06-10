using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string PhotoUrl { get; set; }
        public string Price { get; set; }
        public bool Special { get; set; }
    }
}
