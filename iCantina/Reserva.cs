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
        public TimeSpan Horario { get; set; }


        public Reserva()
        {

        }

        public Reserva(Cliente cliente, Prato prato, Menu menu, Extra extra, Multa multa, TimeSpan horario)
        {
            this.Cliente = Cliente;
            this.Prato = Prato;
            this.Menu = Menu;
            this.Extra = Extra;
            this.Multa = Multa;
            Horario = horario;
        }

        public override string ToString()
        {
            return "Cliente: " + Cliente + "       Prato: " + Prato + "       Menu: " + Menu + "       Extra: " + Extra + "       Multa: " + Multa + "       Data: " + Horario;
        }
    }

}
