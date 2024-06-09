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
        public int ID { get; set; }
        public double Valor {  get; set; }
        public TimeSpan NumHoras { get; set; }

        public Multa(double valor, TimeSpan numHoras)
        {
            Valor = valor;
            NumHoras = numHoras;
        }

        public Multa()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        // OVERRIDE PARA DIZER O QUE VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return "Valor da Multa: " + Valor + "       Hora da Multa: " + NumHoras;
        }
    }

}
