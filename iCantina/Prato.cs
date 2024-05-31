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
        public string descricaoPrato {  get; set; }
        public string tipoPrato { get; set; }
        public string estadoPrato { get; set; }

        public Prato(string descricaoPrato, string tipoPrato, string estadoPrato)
        {
            this.descricaoPrato = descricaoPrato;
            this.tipoPrato = tipoPrato;
            this.estadoPrato = estadoPrato;
        }

        public Prato() // Construtor vazio para o entity framework
        {

        }

        // OVERRIDE PARA DIZER O QUE VAI ESCREVER NA LISTBOX
        public override string ToString()
        {
            return "Prato: " + descricaoPrato + " Tipo: " + tipoPrato + " Estado: " + estadoPrato;
        }
    }
}
