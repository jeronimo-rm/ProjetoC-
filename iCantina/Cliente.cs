using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Cliente : Utilizador
    {
        [Key] 
        public decimal Saldo { get; set; }

        public Cliente(string nomeUtilizador, int nifUtilizador, decimal saldo) : base(nomeUtilizador, nifUtilizador)
        {
            Saldo = saldo;
        }

        public Cliente()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        public override string ToString()
        {
            return "Nome: " + NomeUtilizador + "       NIF: " + NIFUtilizador + "      Saldo: " + Saldo + "€";
        }

    }
}
