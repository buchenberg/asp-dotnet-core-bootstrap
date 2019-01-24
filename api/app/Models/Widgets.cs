using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Widgets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
    }
}
