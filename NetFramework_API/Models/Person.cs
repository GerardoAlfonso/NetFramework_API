using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFramework_API.Models
{
    public class Person
    {
        [Key]
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}