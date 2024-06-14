using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Fatura
    {
        [Key]
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; }

        public Fatura(int id, decimal total, DateTime dataHora, Cliente cliente, Menu menu)
        {
            Id = id;
            Total = total;
            DataHora = dataHora;
            Cliente = cliente;
            Menu = menu;
        }

        public Fatura() 
        { 

        }
    }
}
