using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Multa
    {
        [Key]
        public decimal Valor {  get; set; }
        public TimeSpan NumHoras { get; set; }

        public Multa(decimal valor, TimeSpan numHoras)
        {
            Valor = valor;
            NumHoras = numHoras;
        }

        public Multa()
        {
            // Construtor vazio necessário para o Entity Framework
        }
    }

}
