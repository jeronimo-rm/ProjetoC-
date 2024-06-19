using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Menu
    {
        [Key]
       public int Id { get; set; }

        public Prato Prato { get; set; }
        public Extra Extra { get; set; }
        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan Horario { get; set; }


        public Menu(Prato Prato, Extra Extra, decimal precoEstudante, decimal precoProfessor, int quantidade,TimeSpan horario)
        {
           
            this.Prato = Prato;
            this.Extra = Extra;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
            Quantidade = quantidade;
            Horario = horario;
        }
        // Construtor sem parâmetros
        public Menu()
        {

        }
        public override string ToString()
        {
           return "Prato: " + Prato.DescricaoPrato  + "Extra: " + Extra.DescricaoExtra + "Preço Estudante: " + PrecoEstudante +"€   Preço Professor: " + PrecoProfessor + "€   Quantidade:" + Quantidade;
        }

    }
}
