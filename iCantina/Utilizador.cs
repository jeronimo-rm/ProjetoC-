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
        public double NIFUtilizador { get; set; }

        public Utilizador(int id, string nomeutilizador, double nifutilizador)
        {
            Id = id;
            NomeUtilizador = nomeutilizador;
            NIFUtilizador = nifutilizador;
        }

        public Utilizador()
        {
            // Construtor vazio necessário para o Entity Framework
        }

    }

}
