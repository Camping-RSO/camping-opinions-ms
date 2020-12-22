using System;
using System.Collections.Generic;

namespace CampingOpinionsAPI.Models
{
    public partial class Mnenja
    {
        public int MnenjeId { get; set; }
        public string Mnenje { get; set; }
        public int? Ocena { get; set; }
        public int Uporabnik { get; set; }
        public int Avtokamp { get; set; }
    }
}
