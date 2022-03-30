using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Entities
{
    public class Country
    {
        public int id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "El campo {0} debe contener al menos un caracter")]

        public string name { get; set; }
        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}
