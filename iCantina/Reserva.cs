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
        public int IdCliente { get; set; }
        public int IdPrato { get; set; }
        public int IdMenu { get; set; }
        public int IdExtra { get; set; }
        public int IdMulta { get; set; }
        public DateTime DataReserva { get; set; }


        public Reserva()
        {

        }

        public Reserva(int idCliente, int idPrato, int idMenu, int idExtra, int idMulta, DateTime dataReserva)
        {
            IdCliente = idCliente;
            IdPrato = idPrato;
            IdMenu = idMenu;
            IdExtra = idExtra;
            IdMulta = idMulta;
            DataReserva = dataReserva;
        }

        public override string ToString()
        {
            return "Cliente: " + IdCliente + "       Prato: " + IdPrato + "       Menu: " + IdMenu + "       Extra: " + IdExtra + "       Multa: " + IdMulta + "       Data: " + DataReserva;
        }
    }

}
