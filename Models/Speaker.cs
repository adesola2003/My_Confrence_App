using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Confrence_App.Models
{
    public class Speaker
    {
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public string Image { get; set; } = "https://media.licdn.com/media/AAYQAQSOAAgAAQAAAAAAAB-zrMZEDXI2T62PSuT6kpB6qg.png";
    }
}
