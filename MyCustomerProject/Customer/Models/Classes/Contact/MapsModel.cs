using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Models.Classes.Contact
{
    public class MapsModel
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
        public string Description { get; set; }
    }
}