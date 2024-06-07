using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Prato Prato { get; set; }
        public Menu Menu { get; set; }
        public Extra Extra { get; set; }
        public Multa Multa { get; set; }
        public DateTime DataReserva { get; set; }


        public Reserva()
        {

        }

        public Reserva(int id, Cliente cliente, Prato prato, Menu menu, Extra extra, Multa multa, DateTime dataReserva)
        {
            Id = id;
            Cliente = cliente;
            Prato = prato;
            Menu = menu;
            Extra = extra;
            Multa = multa;
            DataReserva = dataReserva;
        }

        public override string ToString()
        {
            return "Cliente: " + Cliente + "       Prato: " + Prato + "       Menu: " + Menu + "       Extra: " + Extra + "       Multa: " + Multa + "       Data: " + DataReserva;
        }
    }

}
