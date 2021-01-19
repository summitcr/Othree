using System;
using System.Collections.Generic;

#nullable disable

namespace Othree.Data.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birth { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
    }
}
