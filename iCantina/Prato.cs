 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Prato
    {
        [Key]
        public int Id { get; set; }
        public string DescricaoPrato { get; set; }
        public string TipoPrato { get; set; }
        public string EstadoPrato { get; set; }

        public Prato() // Construtor vazio para o entity framework
        {

        }

        public Prato(string descricaoPrato, string tipoPrato, string estadoPrato)
        {
            DescricaoPrato = descricaoPrato;
            TipoPrato = tipoPrato;
            EstadoPrato = estadoPrato;
        }

        // OVERRIDE PARA DIZER O QUE VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return "Prato: " + DescricaoPrato + "       Tipo: " + TipoPrato + "     Estado: " + EstadoPrato;
        }
    }
}
