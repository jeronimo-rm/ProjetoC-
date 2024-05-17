using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    public class Utillizadores
    {
        [Key]
        public int Id { get; set; }
        public string NomeUtilizador { get; set; }
        public string NIF { get; set; }
    }

}
