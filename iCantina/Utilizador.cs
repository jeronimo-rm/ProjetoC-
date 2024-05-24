using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }
        public string NomeUtilizador { get; set; }
        public int NIFUtilizador { get; set; }

        public Utilizador(string nomeutilizador, int nifutilizador)
        {
            NomeUtilizador = nomeutilizador;
            NIFUtilizador = nifutilizador;
        }

        public Utilizador()
        {
            // Construtor vazio necessário para o Entity Framework
        }

    }

}
