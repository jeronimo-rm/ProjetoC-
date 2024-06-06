using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string DescricaoMenu { get; set; }
        public int IdPrato { get; set; }
        public int IdExtra { get; set; }
        public int PrecoEstudante { get; set; }
        public int PrecoProfessor { get; set; }
        public int Quantidade { get; set; }

        public Menu()
        {

        }

        public Menu(string descricaoMenu, int idPrato, int idExtra, int precoEstudante, int precoProfessor, int quantidade)
        {
            DescricaoMenu = descricaoMenu;
            IdPrato = idPrato;
            IdExtra = idExtra;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            var db = new ApplicationContext();
            var nomePrato = db.Pratos.Find(IdPrato);
            var nomeExtra = db.Extras.Find(IdExtra);
            return "Menu: " + DescricaoMenu + "    Prato: " + nomePrato.descricaoPrato + "     Extra: " + nomeExtra.DescricaoExtra + "     Preço Estudante: " + PrecoEstudante + "€    Preço Professor: " + PrecoProfessor + "€       Quantidade: " + Quantidade;
        }
    }
}
