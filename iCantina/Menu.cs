using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCantina
{
    [Serializable]
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Prato")]
        public int PratoId { get; set; }
        public virtual Prato Prato { get; set; }

        [ForeignKey("Extra")]
        public int ExtraId { get; set; }
        public virtual Extra Extra { get; set; }

        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan Horario { get; set; }

        public Menu(Prato prato, Extra extra, decimal precoEstudante, decimal precoProfessor, int quantidade, TimeSpan horario)
        {
            this.Prato = prato;
            this.Extra = extra;
            this.PrecoEstudante = precoEstudante;
            this.PrecoProfessor = precoProfessor;
            this.Quantidade = quantidade;
            this.Horario = horario;
        }

        // Construtor sem parâmetros
        public Menu()
        {
        }

        public override string ToString()
        {
            return $"Prato: {Prato.DescricaoPrato} Extra: {Extra.DescricaoExtra} Preço Estudante: {PrecoEstudante}€ Preço Professor: {PrecoProfessor}€ Quantidade: {Quantidade}";
        }
    }
}
