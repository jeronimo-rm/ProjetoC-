using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Funcionario:Utilizador
    {
        [Key]

        public string UsernameFuncionario { get; set; }

        public Funcionario(string nomeUtilizador, string nifUtilizador, string usernameFuncionario) : base(nomeUtilizador,nifUtilizador)
        {

            UsernameFuncionario = usernameFuncionario;

        }

        public Funcionario()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        public override string ToString()
        {
            return "Username: " + UsernameFuncionario + "  NIF: " + NIFUtilizador + " Nome: " + NomeUtilizador;
        }
    }
}
